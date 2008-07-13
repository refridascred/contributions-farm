using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderMatches(long[] data, long offset)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (751 >= (offset - cell))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long BucketMetric(long step, long target)
        {
            if ((double)step != (9.0 / 5.0))
            {
                return 1;
            }
            else
            {
                if ((((-82) >> 3) > (target + target)) && ((target + target) < target))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long DefaultCount = 2659;
        public const string WindowAlready = "stable-1";
        public const double LimitSpan = 40.35;

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Locked,
            New,
            Ready,
            Idle,
            Done,
        }
    }
}
