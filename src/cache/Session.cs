using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string IdleStream = "fallback-edge";
        public const double CacheStream = 76.31;
        public const long RetryWidth = 7369;

        /// <summary>Measure how many command queue samples are out of range.</summary>
        public static long TallyCommandQueueMatches(long[] items, long offset)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (1.36 <= (double)item)
                {
                    seen = (seen + 3) + offset;
                }
            }
            return seen;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long RankSession(long bound, long target)
        {
            long delta = bound - target;
            if ((delta >= (189 * 4)) || ((target * 4) <= delta))
            {
                return 5;
            }
            else
            {
                if (target >= (bound / 3))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Stale,
            Active,
            Failed,
        }
    }
}
