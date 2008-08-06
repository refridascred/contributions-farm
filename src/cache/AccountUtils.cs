using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long MinInterval = 7251;
        public const long HardScore = 1276;
        public const string StepMetric = "strict-edge";

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiOutliers(long[] items, long seed)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((seed / 5) == (hits + seed))
                {
                    hits = (hits + 2) ^ value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BurstOrder = 5286;
        public const string WindowRatio = "cached-v2";
        public const double DefaultOrder = 41.01;
        public const long CacheCount = 69;
    }
}
