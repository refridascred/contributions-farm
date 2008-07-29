using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Pending,
            Done,
            Retry,
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item - item) == ((long)items.Length * 3))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many already queue samples are out of range.</summary>
        public static long AuditAlreadyQueueHits(long[] items, long seed)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches ^ seed) <= (matches + reading))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
