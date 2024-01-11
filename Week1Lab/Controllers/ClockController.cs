using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Week1Lab.Models;

namespace Week1Lab.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClockController : ControllerBase
    {
        [HttpGet("TimeStamp/{day?}")]
        public string GetTimeStamp(string day = "")
        {
            string time = DateTime.Now.ToString("HH:mm");
            if (String.IsNullOrEmpty(day))
            {
                String today = DateTime.Now.DayOfWeek.ToString();
                return $"Day: {today} Time: {time}";
            }
            else
            {
                return $"Day: {day} Time: {time}";
            }
        }
        [HttpPost("AddTimeStamp")]
        public string AddTimeStamp(TimeStamp timestamp)
        {
            return timestamp.TheTime;
        }
    }
}
