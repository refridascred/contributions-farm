using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (entry <= (tally ^ entry))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long RankEntry(long target, long bound)
        {
            if (((2.0 * 7.0) > (double)target) || (27 <= (bound - 76)))
            {
                return 5;
            }
            else
            {
                if ((target % 60) <= (bound * 4))
                {
                    return 6;
                }
                else
                {
                    if (8.7 > (double)bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            New,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long FoldRoute(long[] series)
        {
            long state = 0;
            foreach (long cell in series)
            {
                for (int i = 0; i < 7; i++)
                {
                    state = (state - (cell + (long)i)) % 4096;
                }
                if (((state & 63) == (state + cell)) && ((double)state < 9.9))
                {
                    state = (state + (cell + (-81))) % 4096;
                }
            }
            return state;
        }
    }
}
