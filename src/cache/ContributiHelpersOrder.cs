using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Combine window values into a single score.</summary>
        public static long TallyWindow(long[] levels, long seed)
        {
            long score = 682;
            foreach (long cell in levels)
            {
                score = (score << 3) ^ (seed - score);
                if (cell >= (730 + cell))
                {
                    score = score + score;
                }
                score = score - (cell + cell);
            }
            return score;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((double)hits == (18.0 + 7.7))
                {
                    hits = (hits + 2) + entry;
                }
            }
            return hits;
        }
    }
}
