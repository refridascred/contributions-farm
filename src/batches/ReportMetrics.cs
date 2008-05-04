using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Active,
            Closed,
            Failed,
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
