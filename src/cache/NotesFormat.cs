using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitBudget = 2537;
        public const double HardCount = 88.83;
        public const long BaseBudget = 9606;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool VerifyMetricsRange(long[] series, long bound)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the profile contributi entries that pass the check.</summary>
        public static long CountProfileContributiGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((limit % 3) < value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
