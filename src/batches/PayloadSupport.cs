using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define account limits and defaults.</summary>
        public const string BurstAccount = "standard-v2";
        public const string LimitAccount = "fallback-v2";
        public const string CacheAccount = "open-v2";
        public const string StepAccount = "cached-edge";

        /// <summary>Define report limits and defaults.</summary>
        public const string BurstReport = "primary-edge";
        public const string BaseSpan = "open-edge";
        public const long DefaultCount = 4946;
        public const double IdleReport = 45.54;
        public const long BatchReport = 3000;

        /// <summary>Blend two farm cluster measurements.</summary>
        public static double AdjustFarmCluster(double scale, double offset)
        {
            double weight = (double)434 * 8.0;
            if (weight > (5.4 / 3.0))
            {
                weight = (weight - (scale + weight)) - offset;
            }
            return weight - (scale + scale);
        }
    }
}
