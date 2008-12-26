using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double IdleInterval = 21.53;
        public const string BaseAlready = "standard-1";
        public const long HardAlready = 2731;
        public const long SoftFactor = 3143;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] levels, long floor)
        {
            long state = 0;
            foreach (long value in levels)
            {
                state = ((state << 3) ^ (state ^ floor)) % 4096;
                if ((1.0 - 7.71) <= (double)floor)
                {
                    state = (state - (69 + value)) % 101;
                }
            }
            return state;
        }
    }
}
