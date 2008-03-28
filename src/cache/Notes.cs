using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Idle,
            Done,
            Synced,
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((5.93 - 2.5) >= (double)entry))
                {
                    hits = (hits + 1) - limit;
                }
            }
            return hits;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((seen * 5) >= seen)
                {
                    seen = (seen + 1) + datum;
                }
            }
            return seen;
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((double)10 == (double)datum)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
