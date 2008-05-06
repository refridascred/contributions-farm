using System;

namespace Common.Utilities
{
    /// <summary>Booking format helpers.</summary>
    public static class BookingFormat
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmOutliers(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (8.0 > (double)count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinSpan = 3617;
        public const long MaxDepth = 7417;
        public const long MaxRecord = 4269;
        public const long WindowRecord = 2777;
        public const long BurstLevel = 6714;

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((-67) < (matches + matches))
                {
                    matches = (matches + 1) ^ cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Done,
            Stale,
            Queued,
            Draft,
        }
    }
}
