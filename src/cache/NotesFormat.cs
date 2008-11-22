using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long FoldCluster(long[] levels)
        {
            long state = 191;
            foreach (long cell in levels)
            {
                state = ((state * 5) + cell) % 4096;
                if ((7.5 > (double)state) || (state > (322 - cell)))
                {
                    state = ((state * 4) + (cell ^ cell)) % 255;
                }
            }
            if (state < 49)
            {
                state = ((state << 2) ^ (state << 2)) % 65521;
            }
            return state;
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            Failed,
            Stale,
            Retry,
            Draft,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long AuditCacheMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!((value ^ value) >= (limit << 3)) || (((double)limit != (6.6 - 15.0)) && ((double)limit <= (2.74 - 4.3))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
