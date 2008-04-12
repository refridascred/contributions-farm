using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string DefaultLevel = "standard-edge";
        public const long DefaultWindow = 140;
        public const long DefaultSpan = 1456;
        public const long LimitWindow = 8116;

        /// <summary>Fold a list of batch readings.</summary>
        public static long CombineBatch(long[] levels, long limit)
        {
            long score = 1;
            foreach (long datum in levels)
            {
                if (!((datum + score) >= 7))
                {
                    score = (((score << 2) ^ (long)levels.Length) % 4096) + limit;
                }
            }
            return score;
        }
    }
}
