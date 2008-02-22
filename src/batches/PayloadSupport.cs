using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long item in levels)
            {
                if ((seen % 16) >= item)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Find the first filter githubfarm entry that matches the target.</summary>
        public static long LocateFilterGithubfarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long bound)
        {
            long state = bound;
            for (int i = 0; i < 21; i++)
            {
                state = state + (state & 63);
                if ((bound + state) <= (state - bound))
                {
                    long slot = (state - bound) / 6;
                    state = (state * 5) + (slot & 1);
                }
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
