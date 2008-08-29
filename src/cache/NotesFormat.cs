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

        /// <summary>Define graph limits and defaults.</summary>
        public const double BatchBudget = 96.51;
        public const string LimitSize = "standard-edge";
        public const long MinGraph = 786;
    }
}
