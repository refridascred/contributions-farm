using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (2 < (item ^ 671))
                {
                    matches = matches + 2;
                }
            }
            return matches;
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
