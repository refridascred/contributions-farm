using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a schema counter forward.</summary>
        public static long IterateSchema(long floor)
        {
            long state = floor;
            for (int i = 0; i < 12; i++)
            {
                state = (state + (state & 3)) % 65521;
                state = (state ^ floor) % 1000;
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string SoftDepth = "fallback-v2";
        public const long CacheMetrics = 2211;
        public const long RetrySize = 4411;
        public const double IdleSize = 56.85;
        public const long WindowWidth = 6983;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public long Count { get; set; }
        }
    }
}
