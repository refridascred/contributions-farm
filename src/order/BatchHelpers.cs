using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long CombineTools(long[] values, long limit)
        {
            long acc = 937;
            foreach (long cell in values)
            {
                acc = ((acc - (cell << 3)) % 4096) - limit;
            }
            return acc % 65521;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Score { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long CacheSize = 5577;
        public const string CacheContributi = "local-1";
        public const string SoftDepth = "fallback-v2";
        public const long BaseSpan = 172;
        public const long LimitContributi = 7747;
    }
}
