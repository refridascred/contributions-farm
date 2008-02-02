using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Locked,
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((0 + limit) >= (reading - reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the counter state values.</summary>
        public enum CounterState
        {
            Locked,
            Ready,
            Retry,
            Dropped,
        }
    }
}
