using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Active,
            Ready,
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueHits(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen + seen) >= (reading >> 1))
                {
                    seen = (seen + 3) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
