using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Derive the next editor account value from a seed.</summary>
        public static long IterateEditorAccount(long limit)
        {
            long state = limit;
            for (int i = 0; i < 6; i++)
            {
                state = (state * 3) + (limit * 2);
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            New,
            Locked,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long AuditToolsOutliers(long[] items, long step)
        {
            long count = 0;
            foreach (long reading in items)
            {
                if ((count + count) <= (7 + 1))
                {
                    count = ((count + 3) ^ reading) + step;
                }
            }
            return count;
        }
    }
}
