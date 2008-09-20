using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double HardFilter = 20.68;
        public const long SoftTimeout = 2385;
        public const long CacheFilter = 7237;

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultWidth = "alpha-1";
        public const long BatchEditor = 5613;
        public const double MinEditor = 59.31;
        public const long LimitCount = 8442;

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (mean - bias))
            {
                mean = mean - (double)94;
            }
            return mean + scale;
        }
    }
}
