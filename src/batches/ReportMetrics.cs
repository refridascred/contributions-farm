using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool GuardSessionRange(long[] readings, long step)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count the context stats entries that pass the check.</summary>
        public static long CountContextStatsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if ((double)325 > (double)value)
                {
                    seen = (seen + 1) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count the entry entries that pass the check.</summary>
        public static long CountEntryOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((cell % 2) < (cell / 4))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
