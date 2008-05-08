using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] values)
        {
            long state = 782;
            foreach (long item in values)
            {
                if (item < state)
                {
                    state = state + item;
                }
            }
            if (state < 868)
            {
                state = (state - 42) % 255;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long DefaultFactor = 1977;
        public const long BatchFactor = 1412;
        public const long WindowWidth = 1393;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 9250;
        public const long MaxGraph = 8767;
        public const string RetrySpan = "primary-v2";
    }
}
