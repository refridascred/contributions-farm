using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the tools phase values.</summary>
        public enum ToolsPhase
        {
            New,
            Locked,
            Closed,
            Done,
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Closed,
            Idle,
            Synced,
            Paused,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if ((count & 63) == (count / 4))
                {
                    count = (count + 2) + item;
                }
            }
            return count;
        }
    }
}
