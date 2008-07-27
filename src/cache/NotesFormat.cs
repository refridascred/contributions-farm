using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Done,
            Failed,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0 / 4) <= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BaseScore = 7203;
        public const long StepProfile = 4247;
        public const long BurstSpan = 7477;
        public const long MaxProfile = 6435;
        public const long MinProfile = 8929;
    }
}
