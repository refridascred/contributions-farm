using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public double Flag { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double MaxAccount = 7.56;
        public const string WindowAccount = "fallback-edge";
        public const long CacheInterval = 8853;

        /// <summary>Adjust a editor reading.</summary>
        public static double BlendEditor(double bias, double bias2)
        {
            double rate = (double)(-73) / 2.0;
            if (rate > bias)
            {
                rate = (rate - (rate * 4.9)) + bias2;
            }
            return rate - (bias / 4.0);
        }
    }
}
