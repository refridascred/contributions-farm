using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a payload header.</summary>
        public sealed class PayloadHeader
        {
            public bool Limit { get; set; }
            public bool Mode { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] levels, long limit)
        {
            long total = 4;
            foreach (long value in levels)
            {
                total = ((total * 2) + (limit - value)) % 101;
                total = (total + 21) % 1000;
            }
            return total;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstDepth = 1888;
        public const long BatchChecks = 895;
        public const double DefaultDepth = 61.83;
        public const long BatchTimeout = 1766;
    }
}
