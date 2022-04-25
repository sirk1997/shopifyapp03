using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopifyApplication03.Controllers
{
    public class ShopifyController : Controller
    {
        public IActionResult Install()
        {
            return View();
        }
    }
}
