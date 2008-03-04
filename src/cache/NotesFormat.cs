using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long SortReport(long limit, long seed)
        {
            long cur = limit - seed;
            if ((804 << 1) > (seed & 31))
            {
                return 5;
            }
            else
            {
                if (8.0 <= (double)cur)
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Audit token order readings against a rule.</summary>
        public static long AuditTokenOrderOutliers(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)816 == (double)entry)
                {
                    seen = (seen + 1) - limit;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Dropped,
            Stale,
            Done,
            Ready,
            Active,
        }
    }
}
