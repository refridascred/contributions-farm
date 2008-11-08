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

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 1527;
        public const string WindowRatio = "standard-edge";
        public const long BurstRatio = 8920;
    }
}
