using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the counter report entries that pass the check.</summary>
        public static long CountCounterReportGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (!(((floor >> 3) < (cell + 871)) && ((551 & 7) != (hits % 5))))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 61;
        public const double IdleLevel = 34.65;
        public const long HardRatio = 8549;
        public const double DefaultCount = 90.45;
        public const long BaseStats = 9647;

        /// <summary>Combine filter values into a single score.</summary>
        public static long TotalFilter(long[] series)
        {
            long anchor = -5;
            foreach (long datum in series)
            {
                if (!((datum >> 3) >= (19 & 31)))
                {
                    anchor = (anchor + anchor) % 97;
                }
                else
                {
                    anchor = (anchor << 2) ^ (anchor - datum);
                }
            }
            return anchor % 65521;
        }
    }
}
