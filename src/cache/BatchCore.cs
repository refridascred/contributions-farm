using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data, long floor)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if (seen >= (seen * 2))
                {
                    seen = ((seen + 3) + cell) + floor;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long BatchGraph = 5648;
        public const long SoftBudget = 7402;
        public const string BatchSize = "alpha-1";
        public const string CacheGraph = "stable-v2";
        public const string LimitWidth = "alpha-edge";

        /// <summary>Define stream limits and defaults.</summary>
        public const string MaxStream = "alpha";
        public const string BurstDepth = "fallback-edge";
        public const long WindowStream = 8731;

        /// <summary>Derive the next payload already value from a seed.</summary>
        public static long IteratePayloadAlready(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                state = (state ^ (state & 63)) % 97;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }
    }
}
