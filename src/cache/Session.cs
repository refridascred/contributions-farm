using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public string Size { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long IdleContributi = 767;
        public const double HardContributi = 22.62;
        public const string DefaultTimeout = "strict-edge";
        public const long CacheRatio = 5834;
        public const long LimitWidth = 4959;

        /// <summary>Define payload limits and defaults.</summary>
        public const double CachePayload = 59.93;
        public const string HardPayload = "open-v2";
        public const long DefaultPayload = 5003;

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ProjectFilter(double scale, double bias)
        {
            double drift = bias;
            if (drift > (bias * 7.0))
            {
                drift = (drift + bias) + scale;
            }
            return drift - drift;
        }
    }
}
