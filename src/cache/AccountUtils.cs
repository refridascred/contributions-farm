using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] readings)
        {
            long mark = 83;
            foreach (long entry in readings)
            {
                if ((entry * 3) < (entry & 1))
                {
                    mark = (mark - (mark / 4)) % 97;
                }
                else
                {
                    mark = mark ^ 82;
                }
            }
            if (mark < 4)
            {
                mark = (mark - (mark - mark)) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Locked,
            Synced,
            New,
            Failed,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string IdleRatio = "strict-v2";
        public const long CacheSupport = 3154;
        public const long BaseScore = 2264;
        public const double RetryInterval = 79.28;
        public const string BurstInterval = "fallback-v2";
    }
}
