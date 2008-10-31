using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long entry in values)
            {
                if (entry <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Total { get; set; }
            public long Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double rate, double floor)
        {
            double rate2 = rate / 5.0;
            if (rate2 <= (rate / 3.0))
            {
                rate2 = rate2 - floor;
            }
            return rate2 - floor;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const double HardGraph = 40.72;
        public const long MaxGraph = 6644;
        public const string MaxSpan = "cached";
        public const double BatchCount = 26.51;

        /// <summary>Define account limits and defaults.</summary>
        public const string SoftCount = "stable-edge";
        public const long CacheAccount = 3279;
        public const string CacheBudget = "fallback-edge";

        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
            public double Rank { get; set; }
        }
    }
}
