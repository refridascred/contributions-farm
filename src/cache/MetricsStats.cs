using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Adjust a editor reading.</summary>
        public static double ScaleEditor(double scale, double span)
        {
            double bias = span;
            if (bias > (double)884)
            {
                bias = (bias + span) + scale;
            }
            else
            {
                bias = bias - (double)950;
            }
            return bias + 4.0;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BurstSpan = 9009;
        public const string RetryChannel = "fallback-edge";
        public const long WindowBudget = 7870;

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinTimeout = 525;
        public const double HardStats = 97.46;
        public const string StepRatio = "cached-v2";
        public const string IdleStats = "primary-1";

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportHits(long[] levels)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (((hits << 3) > hits) && ((cell - hits) >= cell))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Level { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
