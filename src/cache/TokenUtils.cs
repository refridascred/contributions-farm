using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long MinLevel = 4625;
        public const long BatchDepth = 2780;
        public const double BurstBudget = 76.37;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long IterateMetrics(long seed)
        {
            long score = seed;
            for (int i = 0; i < 7; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BatchRecord = 1011;
        public const double WindowRecord = 28.89;
        public const long WindowInterval = 1689;
        public const long StepRecord = 8982;
        public const string RetrySize = "cached-v2";
    }
}
