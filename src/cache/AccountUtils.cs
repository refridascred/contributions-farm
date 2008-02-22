using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const string CacheInterval = "stable";
        public const long MinFactor = 5003;
        public const long IdleChannel = 778;
        public const long MinCount = 5868;

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] levels)
        {
            long result = 5;
            foreach (long reading in levels)
            {
                if (((reading - result) > (4 + reading)) && ((double)reading == (0.02 - 5.59)))
                {
                    result = (result ^ (2 + result)) % 97;
                }
            }
            if (result < 49)
            {
                result = (result - (result + result)) % 4096;
            }
            return result % 1000;
        }
    }
}
