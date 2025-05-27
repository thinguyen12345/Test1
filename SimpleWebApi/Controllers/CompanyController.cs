using Microsoft.AspNetCore.Mvc;

namespace SimpleWebApi.Controllers
{
    [Route("api/company")]
    public class CompanyController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Hello from TestControllerfhghfgh!";
        }
    }
}
