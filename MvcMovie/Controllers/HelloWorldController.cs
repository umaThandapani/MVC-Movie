using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        //// GET: HelloWorld
        //public ActionResult Index()
        //{
        //    return View();
        //}

        //// GET: HelloWorld
        public string index()
        {
            return "This is my <b> default </b> action... ";
        }


        ////// GET: HelloWorld/Welcome
        //public string Welcome()
        //{
        //    return "This is the Welcome action method....";
        //}

        //// Adding parameters in the welcome method to add query in the browser
        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode ("Hello " + name + ", NumTimes is: " + numTimes);
        }


    }
}