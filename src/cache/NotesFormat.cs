using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Closed,
            Paused,
            Idle,
            Pending,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsMatches(long[] levels, long offset)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (3.5 <= (double)hits)
                {
                    hits = ((hits + 3) + reading) + offset;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long SortWindow(long bound, long offset)
        {
            long cur = bound ^ offset;
            if ((double)offset <= (double)bound)
            {
                return 4;
            }
            else
            {
                if (((bound ^ cur) < (cur % 12)) && ((double)offset > 2.6))
                {
                    return 7;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
