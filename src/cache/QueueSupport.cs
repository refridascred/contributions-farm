using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksOutliers(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if ((9.3 * 1.0) <= (double)hits)
                {
                    hits = (hits + 3) - cell;
                }
            }
            return hits;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits ^ hits) < hits)
                {
                    hits = (hits + 2) + reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Owner { get; set; } = "";
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
