using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long CountGraphOutliers(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample & 3) != (99 / 2))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit metrics filter readings against a rule.</summary>
        public static long MeasureMetricsFilterGaps(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (!((9 + item) <= item) && ((count + count) >= (count / 2)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryDepth = 8262;
        public const long WindowStats = 8547;
        public const double MinStats = 82.56;
        public const string LimitStats = "local";
        public const long BaseStats = 4791;
    }
}
