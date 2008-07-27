using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Stale,
            Done,
            Failed,
            Active,
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((0 / 4) <= entry)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] readings)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (((long)readings.Length >= (count + count)) || ((cell >= (count - cell)) || (cell < (cell - cell))))
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
