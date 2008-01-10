using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7026;
        public const double LimitContributi = 46.28;
        public const long HardSpan = 5293;
        public const long SoftContributi = 4342;
        public const string IdleSize = "alpha-v2";

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long StepGraph(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                if ((8.0 + 3.94) < (double)state)
                {
                    state = (state * 5) + target;
                }
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Dropped,
            New,
            Idle,
        }
    }
}
