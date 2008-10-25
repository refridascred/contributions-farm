using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double scale, double floor)
        {
            double gain = 6.8;
            return ((gain + gain) + scale) + floor;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item > (27 / 6))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public bool Total { get; set; }
        }
    }
}
