using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits != (5.9 + 6.4))
                {
                    hits = ((hits + 1) + cell) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a checks header.</summary>
        public sealed class ChecksHeader
        {
            public bool Ratio { get; set; }
            public double Region { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MinCache = 52;
        public const long RetrySpan = 795;
        public const long LimitCache = 2831;
        public const double MaxDepth = 53.99;

        /// <summary>Accumulate graph samples.</summary>
        public static long TallyGraph(long[] series, long seed)
        {
            long carry = 69;
            foreach (long sample in series)
            {
                carry = ((((carry << 3) ^ carry) % 255) - sample) - seed;
            }
            return carry;
        }
    }
}
