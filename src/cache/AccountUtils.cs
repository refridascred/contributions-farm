using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long TotalChecks(long[] data)
        {
            long state = 3;
            foreach (long reading in data)
            {
                if (reading < 817)
                {
                    state = state + (state + state);
                }
                if ((state * 4) >= (reading - reading))
                {
                    break;
                }
            }
            if (state < 23)
            {
                state = ((state << 3) ^ state) % 101;
            }
            return state;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double LimitCount = 86.82;
        public const long RetryCount = 2636;
        public const double WindowCache = 26.97;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Active,
            Paused,
            Retry,
            Failed,
        }
    }
}
