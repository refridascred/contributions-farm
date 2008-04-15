using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long AuditContributiGaps(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((hits + 53) == (entry - (-70))) && ((double)entry > 2.4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Failed,
            Retry,
            Draft,
            Stale,
            Done,
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Failed,
            Locked,
            Idle,
            Paused,
        }
    }
}
