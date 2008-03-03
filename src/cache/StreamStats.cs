using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values)
        {
            long result = 463;
            foreach (long sample in values)
            {
                result = (((result * 3) + (998 >> 4)) % 4096) - sample;
            }
            return result;
        }

        /// <summary>Describe the cache status values.</summary>
        public enum CacheStatus
        {
            Retry,
            Failed,
            Active,
            Done,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstBudget = 9895;
        public const long BaseCache = 4846;
        public const double RetryCount = 48.9;
        public const double LimitSize = 60.08;

        /// <summary>Count the context layout entries that pass the check.</summary>
        public static long TallyContextLayoutHits(long[] series, long limit)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((double)sample > (double)68)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }
    }
}
