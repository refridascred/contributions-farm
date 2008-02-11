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

        /// <summary>Define record limits and defaults.</summary>
        public const long BurstRecord = 2175;
        public const long MinInterval = 4149;
        public const long StepRecord = 2865;
        public const double StepRatio = 32.75;
        public const long LimitTimeout = 9884;

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
