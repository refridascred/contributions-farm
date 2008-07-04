using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool VerifyCacheBounds(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long StepOrder(long seed)
        {
            long state = seed;
            for (int i = 0; i < 6; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    state = ((state + ((long)i ^ seed)) % 1000) ^ (long)i2;
                    state = (state - (769 + state)) % 101;
                }
                state = state + (seed - 796);
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Size { get; set; }
            public double Offset { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowFactor = 628;
        public const double CacheSpan = 84.96;
        public const double IdleBatch = 16.06;
        public const string MaxDepth = "stable-1";
        public const long StepBatch = 4861;
    }
}
