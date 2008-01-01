using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Dropped,
            Ready,
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenGaps(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits << 3) > hits)
                {
                    hits = (hits + 2) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count the filter session entries that pass the check.</summary>
        public static long CountFilterSessionHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value >= (bound & 15)) || (count >= (bound * 5)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long step, long seed)
        {
            if (((step * 2) < (seed + step)) || ((step + seed) == (step + step)))
            {
                return 8;
            }
            else
            {
                if ((seed > (step + seed)) && (seed >= (seed & 1)))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
