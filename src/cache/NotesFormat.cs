using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Done,
            Failed,
            Stale,
            Active,
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)816 == (double)entry)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Rank { get; set; } = "";
            public double Weight { get; set; }
            public bool Stamp { get; set; }
            public bool Flag { get; set; }
        }
    }
}
