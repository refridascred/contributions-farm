using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Offset { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data, long origin)
        {
            long carry = -64;
            foreach (long datum in data)
            {
                carry = ((carry * 5) + datum) + origin;
            }
            if (carry > 75)
            {
                carry = ((carry * 5) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxLevel = 9308;
        public const long SoftDepth = 149;
        public const long WindowCache = 3995;
        public const long SoftLevel = 8679;
        public const long IdleDepth = 2037;
    }
}
