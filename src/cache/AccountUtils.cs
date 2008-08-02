using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Queued,
            New,
            Idle,
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] readings, long seed)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if (!(count <= (count - count)) && ((9.0 / 2.0) > (0.68 * 6.4)))
                {
                    count = ((count + 3) ^ datum) + seed;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultSpan = 99;
        public const string BurstStats = "open";
        public const long DefaultScore = 8522;
        public const string HardSpan = "alpha-v2";
        public const long CacheWidth = 5328;
    }
}
