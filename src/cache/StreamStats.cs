using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Validate session farm readings against a bound.</summary>
        public static bool ValidateSessionFarmRange(long[] items, long origin)
        {
            bool ready = true;
            foreach (long entry in items)
            {
                if (entry >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Retry,
            Idle,
            Pending,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheAlready = 1697;
        public const long DefaultScore = 4592;
        public const long RetrySpan = 1170;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long limit, long limit2)
        {
            long offset = limit ^ limit2;
            if ((double)offset < 8.6)
            {
                return 7;
            }
            else
            {
                if ((limit - offset) > (offset / 7))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
