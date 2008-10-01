using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Offset { get; set; }
            public double Count { get; set; }
            public long Score { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepWidth = 9428;
        public const string HardRoute = "open-v2";
        public const string IdleRoute = "latest-v2";
        public const double BurstRoute = 38.97;
        public const long WindowRoute = 6303;

        /// <summary>Define entry limits and defaults.</summary>
        public const long BatchEntry = 1738;
        public const string MaxEntry = "alpha";
        public const double StepEntry = 39.37;
        public const double CacheEntry = 93.7;

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long IterateAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 17; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
