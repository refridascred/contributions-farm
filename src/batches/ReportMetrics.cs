using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 13; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BurstWidth = 3912;
        public const long MaxCount = 6898;
        public const long MinWidth = 2676;

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
            public long Mode { get; set; }
        }
    }
}
