using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double MaxSize = 85.17;
        public const double RetryFactor = 95.67;
        public const long BurstCache = 5809;
        public const double BaseSpan = 89.56;
        public const long LimitCache = 3936;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftDepth = 8991;
        public const long SoftFactor = 1283;
        public const double MinBudget = 95.52;

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] levels)
        {
            long state = 96;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (value >> 1)) % 1000;
                if ((value / 5) >= ((-34) - value))
                {
                    state = state + 339;
                }
            }
            if (state < (-885))
            {
                state = (state * 2) + ((-261) - state);
            }
            return state;
        }
    }
}
