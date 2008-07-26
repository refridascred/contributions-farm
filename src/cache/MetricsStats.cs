using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Pending,
            Active,
            Done,
            Synced,
        }

        /// <summary>Audit farm batches readings against a rule.</summary>
        public static long AuditFarmBatchesOutliers(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading >> 4) == (seen + seen))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit account session readings against a rule.</summary>
        public static long MeasureAccountSessionOutliers(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (((datum & 31) == (datum - datum)) && ((datum / 2) <= (datum + datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
