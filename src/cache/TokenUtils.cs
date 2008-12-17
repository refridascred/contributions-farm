using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Compare every pair of buffer metric readings.</summary>
        public static long PairBufferMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5405;
        public const long MaxStats = 9798;
        public const double IdleStats = 47.59;
        public const long BatchLevel = 4623;

        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Paused,
            Failed,
            Active,
            Done,
        }
    }
}
