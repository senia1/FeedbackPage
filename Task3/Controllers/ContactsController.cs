using Microsoft.AspNetCore.Mvc;

namespace Task3.Controllers
{
    public class ContactsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
