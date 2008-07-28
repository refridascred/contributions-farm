using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long RankToken(long offset, long seed)
        {
            long span = offset + seed;
            if (!(seed > offset))
            {
                return 0;
            }
            else
            {
                if ((1.9 + 3.8) <= (double)span)
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchSize = 2387;
        public const long MaxContributi = 9506;
        public const long MinCount = 6667;

        /// <summary>Compare every pair of record support readings.</summary>
        public static long PairRecordSupportCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
