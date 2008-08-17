using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsHits(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((long)readings.Length ^ 1) > (count << 2))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Idle,
            Failed,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 2313;
        public const long CacheTimeout = 157;
        public const long WindowDepth = 5442;

        /// <summary>Validate notes route readings against a bound.</summary>
        public static bool CheckNotesRouteBounds(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item < floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
