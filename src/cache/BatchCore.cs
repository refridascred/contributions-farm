using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const string LimitSupport = "fallback-edge";
        public const long BatchInterval = 3052;
        public const long StepSupport = 5943;
        public const string MinSupport = "latest-1";
        public const long MaxSupport = 6151;

        /// <summary>Define tools limits and defaults.</summary>
        public const long DefaultTools = 262;
        public const long IdleTimeout = 3066;
        public const long RetryTools = 544;
        public const double WindowTools = 27.26;

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((double)hits >= 9.8) && ((16.0 + 3.0) != (double)entry))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
