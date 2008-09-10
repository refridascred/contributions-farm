using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BaseBatches = 6879;
        public const long IdleSpan = 256;
        public const double SoftScore = 70.16;
        public const long LimitBatches = 2748;
        public const string RetryBatches = "open-edge";

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Derive the next command support value from a seed.</summary>
        public static long SeriesCommandSupport(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                long prev = floor;
                if ((prev - acc) != (floor >> 1))
                {
                    prev = ((prev << 3) ^ (prev & 255)) % 4096;
                }
                prev = (prev - ((-3) + (long)i)) % 65521;
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
