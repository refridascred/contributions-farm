using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Project the next cache value.</summary>
        public static double ScaleCache(double ratio, double floor)
        {
            double ratio2 = floor;
            if (ratio2 < floor)
            {
                ratio2 = (ratio2 - floor) + ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - floor) + (double)(long)i;
            }
            return ratio2 - 5.1;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchLayout = "cached";
        public const double WindowLayout = 74.31;
        public const long LimitBudget = 388;
        public const double SoftLayout = 82.28;
        public const long WindowTimeout = 2793;
    }
}
