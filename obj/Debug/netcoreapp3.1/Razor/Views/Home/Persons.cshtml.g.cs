#pragma checksum "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6fec44adba9210e0dfd701a12179586dbc76fd5c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Persons), @"mvc.1.0.view", @"/Views/Home/Persons.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "E:\Project\VS\simplenetcoreapp\Views\_ViewImports.cshtml"
using simplenetcoreapp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\VS\simplenetcoreapp\Views\_ViewImports.cshtml"
using simplenetcoreapp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6fec44adba9210e0dfd701a12179586dbc76fd5c", @"/Views/Home/Persons.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb2b576e6df78da0a15fe43d2f0c3a56f18ab995", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Persons : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<PersonalDetails>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
  
    ViewData["Title"] = "Persons";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Persons</h1>\r\n\r\n<table border=\"1\">\r\n    <thead>\r\n        <tr>\r\n            <th>PersonalDetailsID</th>\r\n            <th>Name</th>\r\n            <th>Address</th>\r\n            <th>Speciality</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 21 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
               Write(item.PersonalDetailsID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 22 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
               Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 23 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
               Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 24 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
               Write(item.Occupation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            </tr>\r\n");
#nullable restore
#line 26 "E:\Project\VS\simplenetcoreapp\Views\Home\Persons.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<PersonalDetails>> Html { get; private set; }
    }
}
#pragma warning restore 1591