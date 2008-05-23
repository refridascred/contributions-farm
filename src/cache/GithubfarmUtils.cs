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

        /// <summary>Fold a list of stats readings.</summary>
        public static long WeighStats(long[] items, long bound)
        {
            long mix = 327;
            foreach (long datum in items)
            {
                mix = ((mix ^ (mix & 7)) + datum) + bound;
            }
            return mix;
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
