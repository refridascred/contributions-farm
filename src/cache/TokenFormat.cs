using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Dropped,
            Idle,
            New,
            Synced,
        }

        /// <summary>Count the metric channel entries that pass the check.</summary>
        public static long AuditMetricChannelGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if (((double)reading < 7.0) || ((6.04 - 12.0) == (double)reading))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitWidth = 8262;
        public const double BaseCount = 44.42;
        public const long SoftDepth = 5335;
    }
}
