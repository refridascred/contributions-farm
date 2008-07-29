using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Pending,
            Active,
            Stale,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long WeighAccount(long[] values, long floor)
        {
            long acc = -28;
            foreach (long value in values)
            {
                if (acc >= (2 * 3))
                {
                    acc = (((acc ^ 9) % 255) ^ value) - floor;
                }
            }
            return acc;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultWidth = "staging-edge";
        public const string CacheSize = "fallback-1";
        public const string SoftSize = "primary-edge";
    }
}
