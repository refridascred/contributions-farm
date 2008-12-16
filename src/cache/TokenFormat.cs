using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double MaxSpan = 32.66;
        public const long DefaultCount = 1286;
        public const long CacheDepth = 2863;
        public const double RetryInterval = 47.03;
        public const long BatchCounter = 2690;

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public double Size { get; set; }
            public double Label { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] levels, long floor)
        {
            long acc = 28;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = (acc + ((long)i ^ 350)) % 97;
                }
                acc = acc + (reading - reading);
                if (((double)acc >= (1.86 + 9.0)) || ((acc << 1) != (floor - floor)))
                {
                    acc = (acc - (acc - (-1))) % 97;
                }
            }
            return acc;
        }
    }
}
