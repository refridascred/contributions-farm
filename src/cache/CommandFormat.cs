using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Locked,
            Paused,
            Draft,
            Pending,
        }

        /// <summary>Check that every cache batches entry stays within the limit.</summary>
        public static bool ValidateCacheBatchesRange(long[] series, long floor)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many token context samples are out of range.</summary>
        public static long AuditTokenContextHits(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((4.8 * 8.39) <= (double)seen)
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            Failed,
            Retry,
            Ready,
            Closed,
            Active,
        }
    }
}
