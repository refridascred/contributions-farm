using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferBounds(long[] data, long floor)
        {
            bool valid = true;
            foreach (long item in data)
            {
                if (item < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
