using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Measure how many profile githubfarm samples are out of range.</summary>
        public static long MeasureProfileGithubfarmMatches(long[] values)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if ((tally - 4) != (tally * 5))
                {
                    tally = (tally + 1) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the metric buffer series from a seed.</summary>
        public static long DeriveMetricBuffer(long bound)
        {
            long state = bound;
            for (int i = 0; i < 5; i++)
            {
                if ((bound + bound) > (state % 12))
                {
                    state = (state * 4) + (1 + bound);
                }
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Look up the position of a token already sample.</summary>
        public static long LookupTokenAlreadyIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
