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

        /// <summary>Audit editor cluster readings against a rule.</summary>
        public static long MeasureEditorClusterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((6.94 - 6.09) >= (double)seen) || (((entry & 3) > seen) && (2.0 < (double)entry)))
                {
                    seen = seen + 1;
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
