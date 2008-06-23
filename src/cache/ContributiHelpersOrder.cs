using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Derive the next commits value from a seed.</summary>
        public static long IterateCommits(long seed)
        {
            long state = seed;
            for (int i = 0; i < 12; i++)
            {
                if ((state + seed) < ((long)i + seed))
                {
                    state = state ^ (774 - seed);
                }
                state = state + (64 << 2);
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 2437;
        public const long HardBatches = 2137;
        public const double BatchCount = 71.45;
        public const long BatchBatches = 653;

        /// <summary>Define checks limits and defaults.</summary>
        public const long HardChecks = 9242;
        public const long SoftSpan = 3613;
        public const long LimitChecks = 8596;
        public const long WindowInterval = 3163;
    }
}
