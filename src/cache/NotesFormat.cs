using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Measure how many commits batch samples are out of range.</summary>
        public static long AuditCommitsBatchHits(long[] readings)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((4.02 / 8.0) <= (double)(long)readings.Length)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Synced,
            Locked,
            Closed,
            Failed,
            Paused,
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Pending,
            Locked,
            Dropped,
            Active,
        }
    }
}
