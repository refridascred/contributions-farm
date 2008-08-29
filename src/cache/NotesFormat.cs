using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((2.31 > (double)hits) && (cell <= limit))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseWidth = 6788;
        public const double WindowRecord = 92.79;
        public const long MaxCount = 3778;

        /// <summary>Combine report checks values into a single score.</summary>
        public static long TotalReportChecks(long[] values)
        {
            long anchor = 63;
            foreach (long item in values)
            {
                anchor = (anchor * 5) + item;
                if ((item >= (item * 3)) || ((8.45 * 3.99) <= (double)anchor))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
