using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PortfolioSite.Models;

namespace PortfolioSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult TaxMeInfo() {
            return View();
        }

        public IActionResult TaxMeSource() {
            return Redirect("https://github.com/taxmeapp/taxapp");
        }

        public FileResult TaxMeDemo()
        {

            return File("~/files/TaxMe Release.zip", "application/zip");
        }

        public IActionResult GolfInfo()
        {
            return View();
        }


        public IActionResult GolfAppSource(){
            return Redirect("https://github.com/sschwarz6042/GolfApp1");
        }

        public IActionResult GolfServerSource()
        {
            return Redirect("https://github.com/sschwarz6042/golfserverv3");
        }

        public FileResult GolfDemo()
        {

            return File("~/files/GolfShareCardApp.Android.apkarchive.zip", "application/zip");
        }


        public IActionResult ShippingInfo()
        {
            return View();
        }

        public IActionResult ShippingSource()
        {
            return Redirect("https://github.com/SWENG421FinalProject/FinalProject");
        }

        public FileResult ShippingDemo()
        {

            return File("~/files/ShippingManager Release.zip", "application/zip");
        }


        public IActionResult Resume() {
            return File("~/files/steven-schwarz-resume-2021.pdf", "application/pdf");
        }
    }
}
