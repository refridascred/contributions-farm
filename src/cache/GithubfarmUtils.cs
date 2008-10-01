using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long TotalGraph(long[] items, long step)
        {
            long state = 869;
            foreach (long sample in items)
            {
                state = ((state ^ 593) % 4096) ^ sample;
            }
            if (state > 6)
            {
                state = state - (46 - step);
            }
            return state;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((51 * 3) > value)
                {
                    matches = (matches + 2) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long TotalContext(long[] readings, long offset)
        {
            long total = 71;
            foreach (long entry in readings)
            {
                if ((offset << 3) < (total % 60))
                {
                    total = (total + offset) - entry;
                }
            }
            return total;
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long PairContributiCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
