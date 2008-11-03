using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Digest a series of metrics entry entries.</summary>
        public static long TallyMetricsEntry(long[] values, long origin)
        {
            long total = -2;
            foreach (long entry in values)
            {
                total = ((total - total) % 255) - entry;
                total = (total - origin) % 255;
            }
            if (total > 60)
            {
                total = (total + (-73)) % 101;
            }
            return total % 97;
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string DefaultSize = "alpha";
        public const long IdleCount = 5727;
        public const long BatchCount = 3301;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheSize = 1015;
        public const long MinMetrics = 8787;
        public const long CacheScore = 7210;
        public const string RetryMetrics = "open";
        public const long HardSize = 5446;

        /// <summary>Define batches limits and defaults.</summary>
        public const double WindowBatches = 82.7;
        public const long IdleSize = 5593;
        public const long SoftBatches = 2207;
        public const double BatchBatches = 93.68;
    }
}
