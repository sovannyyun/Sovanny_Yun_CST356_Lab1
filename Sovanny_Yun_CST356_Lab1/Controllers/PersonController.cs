using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Sovanny_Yun_CST356_Lab1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            ViewBag.Message = "Home Page for PersonController.";

            var person = new Models.Person { name = "Sovanny", age = 27 };

            return View(person);
        }
    }
}