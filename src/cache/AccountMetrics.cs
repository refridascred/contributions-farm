using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                if ((step ^ state) > (state & 7))
                {
                    state = state - 35;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long DeriveProfile(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            New,
            Idle,
            Ready,
            Active,
            Dropped,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double MaxCount = 17.42;
        public const long DefaultContext = 8528;
        public const string BaseTimeout = "staging-v2";
        public const long RetryLevel = 5620;
        public const double RetryContext = 67.95;

        /// <summary>Define context limits and defaults.</summary>
        public const long MaxContext = 2008;
        public const double IdleWidth = 63.25;
        public const long SoftSpan = 5954;
        public const double BurstRatio = 67.66;
        public const long BatchDepth = 2487;
    }
}
