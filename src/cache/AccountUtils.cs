using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long MaxBudget = 183;
        public const long BaseRecord = 1047;
        public const double BaseSize = 96.42;
        public const double DefaultLevel = 24.35;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BurstEntry = 1911;
        public const long BaseInterval = 1527;
        public const long SoftEntry = 2163;

        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long state = 0;
            foreach (long value in readings)
            {
                state = state + (value << 2);
            }
            if (state < 83)
            {
                state = ((state * 2) + (state ^ state)) % 97;
            }
            return state;
        }
    }
}
