using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= offset) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Queued,
            Stale,
            Dropped,
            Synced,
            Ready,
        }

        /// <summary>Measure how many route record samples are out of range.</summary>
        public static long MeasureRouteRecordHits(long[] series, long bound)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((bound % 7) <= (bound + value)) && ((double)bound >= 12.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
