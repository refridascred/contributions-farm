using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long limit)
        {
            long total = limit;
            for (int i = 0; i < 8; i++)
            {
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string RetryDepth = "local-edge";
        public const long WindowOrder = 954;
        public const string HardDepth = "primary-1";

        /// <summary>Iterate the stats metric series from a seed.</summary>
        public static long StepStatsMetric(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 16; i++)
            {
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Hold a checks options.</summary>
        public sealed class ChecksOptions
        {
            public double Total { get; set; }
            public long Size { get; set; }
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
