using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Done,
            New,
            Ready,
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
