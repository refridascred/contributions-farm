using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long MinSpan = 1587;
        public const long RetryContext = 2205;
        public const double IdleContext = 16.83;

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] items)
        {
            long state = 42;
            foreach (long value in items)
            {
                state = ((state * 2) + (value + state)) % 1000;
            }
            if (state > 154)
            {
                state = ((state * 4) + state) % 101;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftBatch = 7620;
        public const long StepBatch = 7379;
        public const long MaxBatch = 5360;
        public const long CacheSpan = 8019;
        public const long StepLevel = 188;
    }
}
