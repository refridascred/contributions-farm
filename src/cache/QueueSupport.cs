using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Synced,
            Draft,
            Done,
            Locked,
            Dropped,
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (entry < hits)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Paused,
            Retry,
        }
    }
}
