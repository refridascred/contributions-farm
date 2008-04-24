using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate filter tools readings against a bound.</summary>
        public static bool GuardFilterToolsLimits(long[] items, long floor)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            New,
            Draft,
            Active,
            Failed,
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((item < ((long)readings.Length % 7)) || (seen <= (seen % 64))) || ((double)4 == (double)seen))
                {
                    seen = (seen + 2) + floor;
                }
            }
            return seen;
        }
    }
}
