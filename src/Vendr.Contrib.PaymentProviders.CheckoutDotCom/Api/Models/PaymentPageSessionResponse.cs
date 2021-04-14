﻿using Newtonsoft.Json;

namespace Vendr.Contrib.PaymentProviders.CheckoutDotCom.Api.Models
{
    /// <summary>
    /// Defines a response for a payment page session.
    /// </summary>
    public class PaymentPageSessionResponse
    {
        [JsonProperty("reference")]
        public string Reference { get; set; }

        [JsonProperty("_links")]
        public Links Links { get; set; }
    }

    public class Links
    {
        [JsonProperty("redirect")]
        public Redirect Redirect { get; set; }
    }

    public class Redirect
    {
        [JsonProperty("href")]
        public string Href { get; set; }
    }
}