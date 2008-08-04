using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long OverlapFilterCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long BatchBudget = 8876;
        public const string SoftRatio = "strict";
        public const long BaseTimeout = 3056;
        public const long BaseScore = 2471;

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryBatch = 1409;
        public const string LimitBatch = "stable-1";
        public const long MaxBudget = 3524;
        public const long MaxBatch = 5255;
    }
}
