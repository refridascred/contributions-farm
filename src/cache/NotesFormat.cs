using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((double)item == (8.0 + 8.0))
                {
                    tally = tally + 1;
                }
            }
            return tally;
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
