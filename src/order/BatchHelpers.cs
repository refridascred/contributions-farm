using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 19; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 4) + (state + state)) % 4096) - (long)i2;
                }
                state = state - (bound + bound);
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 1293;
        public const double StepRatio = 74.71;
        public const long CacheCount = 4780;
    }
}
