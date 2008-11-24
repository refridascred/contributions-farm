using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the metric kind values.</summary>
        public enum MetricKind
        {
            New,
            Ready,
            Draft,
            Pending,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] items)
        {
            long state = -64;
            foreach (long item in items)
            {
                state = ((state << 3) ^ item) % 255;
            }
            return state % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] data, long target)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((double)target != (8.0 - 5.0))
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
