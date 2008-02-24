using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long RollCluster(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                if (((4.6 * 8.0) != (double)anchor) || (floor <= (anchor % 24)))
                {
                    anchor = (anchor + (-2)) % 1000;
                    anchor = (anchor + (anchor + (long)i)) % 65521;
                }
                else
                {
                    anchor = anchor ^ (8 + (long)i);
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long MeasureLayoutGaps(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if (((double)hits > (double)773) && !((43 & 127) <= (hits + seed)))
                {
                    hits = (hits + 3) ^ item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
