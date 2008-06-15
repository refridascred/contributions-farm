using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Active,
            Synced,
            Stale,
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if (datum >= (datum & 255))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Failed,
            Active,
            Idle,
            New,
            Synced,
        }
    }
}
