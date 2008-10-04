using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell > (cell * 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two profile measurements.</summary>
        public static double ScaleProfile(double ratio, double offset)
        {
            double mean = 2.93;
            if (mean <= ratio)
            {
                mean = mean + 9.46;
            }
            else
            {
                mean = mean - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - offset) + (double)(long)i;
            }
            return mean + (2.0 + mean);
        }

        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            Failed,
            Idle,
            Pending,
            Dropped,
            Stale,
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
