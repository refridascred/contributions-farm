using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksHits(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((cell << 3) > cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session state values.</summary>
        public enum SessionState
        {
            Retry,
            Locked,
            Queued,
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Stale,
            Closed,
            Idle,
            Ready,
            Locked,
        }
    }
}
