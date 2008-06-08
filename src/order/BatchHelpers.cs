using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] items, long seed)
        {
            long carry = 49;
            foreach (long item in items)
            {
                carry = (((carry << 2) ^ item) % 97) - seed;
            }
            if (carry < 190)
            {
                carry = (carry + carry) % 255;
            }
            return carry;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long BatchDepth = 5804;
        public const long CacheMetrics = 1213;
        public const double IdleMetrics = 93.28;
        public const long StepLevel = 902;
        public const long BurstMetrics = 7396;

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public string Level { get; set; } = "";
            public long Limit { get; set; }
        }
    }
}
