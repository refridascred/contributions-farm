using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long floor)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((5.0 / 6.0) <= (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Validate already window readings against a bound.</summary>
        public static bool VerifyAlreadyWindowRange(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((cell + hits) == ((long)readings.Length ^ cell))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
