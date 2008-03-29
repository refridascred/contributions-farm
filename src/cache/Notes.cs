using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long CacheRecord = 2346;
        public const long BaseRatio = 7442;
        public const long BurstRatio = 4335;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long CountCacheMatches(long[] items, long seed)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (!((double)datum >= 2.5))
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TotalStream(long[] items, long origin)
        {
            long score = 612;
            foreach (long value in items)
            {
                if ((double)origin <= 9.44)
                {
                    score = ((score + (83 >> 1)) % 255) - value;
                }
            }
            return score % 4096;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Failed,
            Ready,
            Dropped,
            Locked,
            Paused,
        }

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Ready,
            Locked,
            Active,
            Dropped,
        }
    }
}
