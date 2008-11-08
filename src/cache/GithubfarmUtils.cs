using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a command editor value against two limits.</summary>
        public static long ClassifyCommandEditor(long bound, long offset)
        {
            if ((bound << 3) < (bound + offset))
            {
                return 6;
            }
            else
            {
                if ((5.5 + 12.0) >= (double)bound)
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Compare every pair of counter stats readings.</summary>
        public static long PairCounterStatsCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountHits(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((956 - 952) < reading)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long ClassifyChannel(long target, long bound)
        {
            long slot = target - bound;
            if ((target >> 2) > slot)
            {
                return 8;
            }
            else
            {
                if (2.9 >= (double)bound)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
