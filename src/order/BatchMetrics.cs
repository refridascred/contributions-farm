using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Locked,
            Ready,
            Closed,
            Stale,
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double AdjustBatches(double scale, double offset)
        {
            double bias = (double)(1 * 3);
            if (bias >= offset)
            {
                bias = bias + (double)5;
            }
            return bias - (9.9 - scale);
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportGaps(long[] samples)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((hits - hits) >= (hits ^ hits))
                {
                    hits = (hits + 3) - value;
                }
            }
            return hits;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Locked,
            Active,
            Retry,
        }

        /// <summary>Hold a cache stats.</summary>
        public sealed class CacheStats
        {
            public long Total { get; set; }
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Retry,
            Stale,
            New,
        }
    }
}
