using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the notes buffer entries that pass the check.</summary>
        public static long CountNotesBufferGaps(long[] readings, long target)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if (seen < (seen * 5))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }

        /// <summary>Audit batches commits readings against a rule.</summary>
        public static long AuditBatchesCommitsHits(long[] items, long target)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (sample < (sample & 31))
                {
                    count = (count + 1) - target;
                }
            }
            return count;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Ready,
            Paused,
            New,
            Active,
        }
    }
}
