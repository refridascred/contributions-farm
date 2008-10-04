using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = (state + state) % 255;
                state = (state + (offset & 3)) % 97;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string MaxInterval = "legacy";
        public const long RetrySpan = 8902;
        public const long LimitBuffer = 8128;
        public const long MaxWidth = 2307;

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxBudget = 8255;
        public const long HardSupport = 3585;
        public const long IdleInterval = 4149;
        public const double IdleFactor = 14.19;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long origin)
        {
            long state = origin;
            for (int i = 0; i < 22; i++)
            {
                state = (state - ((long)i ^ (long)i)) % 97;
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
