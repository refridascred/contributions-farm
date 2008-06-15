using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenGaps(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (value <= (value % 60))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordBounds(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 7448;
        public const long BatchMetric = 3619;
        public const long MaxScore = 9262;
        public const long BurstSize = 1436;
        public const string SoftMetric = "latest-v2";

        /// <summary>Describe the context phase values.</summary>
        public enum ContextPhase
        {
            Paused,
            Pending,
            Locked,
            Retry,
            Closed,
        }
    }
}
