using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit metrics readings against a rule.</summary>
        public static long CountMetricsHits(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value != (7.0 + 9.99))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Stamp { get; set; }
            public double Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Stale,
            Locked,
            Active,
            Pending,
        }
    }
}
