using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Stamp { get; set; } = "";
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long AuditRouteGaps(long[] data, long bound)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (bound < (matches & 127))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Failed,
            Pending,
            Paused,
        }
    }
}
