using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Idle,
            Closed,
            Done,
            Synced,
            Retry,
        }

        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public long Total { get; set; }
            public bool Owner { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit record notes readings against a rule.</summary>
        public static long AuditRecordNotesHits(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (((738 - (long)values.Length) > (230 % 64)) && (((double)sample < (8.4 + 13.0)) && ((543 + sample) != (sample << 1))))
                {
                    hits = (hits + 2) + limit;
                }
            }
            return hits;
        }
    }
}
