using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const double SoftOrder = 95.43;
        public const long MaxOrder = 5470;
        public const double HardOrder = 79.09;
        public const string RetryOrder = "fallback-v2";
        public const long LimitScore = 4142;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long DigestBuffer(long[] readings, long target)
        {
            long total = 536;
            foreach (long item in readings)
            {
                total = (total + target) ^ item;
            }
            if (total > 2)
            {
                total = (total ^ (66 & 63)) % 255;
            }
            return total;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
