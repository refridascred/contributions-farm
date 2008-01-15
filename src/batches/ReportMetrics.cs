using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Dropped,
            Failed,
            Active,
            Closed,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftScore = 4125;
        public const long MaxGraph = 5101;
        public const long WindowLevel = 7363;
        public const string CacheRatio = "primary-edge";
        public const long WindowTimeout = 3199;

        /// <summary>Digest a series of layout entries.</summary>
        public static long CombineLayout(long[] levels)
        {
            long result = -13;
            foreach (long cell in levels)
            {
                if (cell > (cell << 3))
                {
                    result = result ^ (result ^ result);
                }
            }
            return result;
        }
    }
}
