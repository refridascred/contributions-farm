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

        /// <summary>Combine context batch values into a single score.</summary>
        public static long TallyContextBatch(long[] levels)
        {
            long state = 47;
            foreach (long sample in levels)
            {
                state = (state << 3) ^ (sample + sample);
            }
            return state;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long WindowRecord = 9123;
        public const double BatchRecord = 20.1;
        public const long HardRecord = 1387;
        public const long IdleTimeout = 51;
    }
}
