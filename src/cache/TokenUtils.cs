using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultCounter = 2393;
        public const string SoftWidth = "strict-v2";
        public const long BurstCounter = 3229;
        public const string CacheBudget = "staging-edge";

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long TallyEntryGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (entry <= (seed % 16))
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

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
