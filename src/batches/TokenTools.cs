using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long limit)
        {
            long total = limit;
            for (int i = 0; i < 12; i++)
            {
                total = total - (total + 2);
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
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
