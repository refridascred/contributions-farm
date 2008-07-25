using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string BaseContributi = "primary-edge";
        public const double CacheScore = 22.93;
        public const long DefaultWidth = 5169;

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double ratio, double floor)
        {
            double mean = ratio;
            if (mean <= ratio)
            {
                mean = (mean - (mean / 5.0)) + floor;
            }
            return mean - (17.0 - mean);
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string IdleGraph = "fallback-edge";
        public const long SoftBudget = 6963;
        public const string MaxGraph = "standard";

        /// <summary>Define window limits and defaults.</summary>
        public const string WindowDepth = "staging";
        public const long HardWindow = 9358;
        public const long CacheWindow = 2244;
        public const double RetryWindow = 14.54;
    }
}
