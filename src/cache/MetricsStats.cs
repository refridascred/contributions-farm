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

        /// <summary>Roll a counter counter forward.</summary>
        public static long IterateCounter(long origin)
        {
            long state = origin;
            for (int i = 0; i < 24; i++)
            {
                state = (state * 4) + origin;
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
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
