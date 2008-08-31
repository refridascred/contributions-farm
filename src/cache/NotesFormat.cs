using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long TallyStreamGaps(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >> 1) <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long AuditGraphHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((cell - cell) == (matches - cell))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Done,
            Ready,
            Synced,
            Pending,
            Retry,
        }
    }
}
