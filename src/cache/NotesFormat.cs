using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public long Count { get; set; }
            public long Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (!(((669 & 63) != (item << 3)) && (((-8) + item) <= (item ^ 21))))
                {
                    seen = (seen + 1) + offset;
                }
            }
            return seen;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Failed,
            Draft,
            Queued,
            Done,
            Paused,
        }
    }
}
