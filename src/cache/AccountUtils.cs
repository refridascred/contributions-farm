using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the metric report entries that pass the check.</summary>
        public static long MeasureMetricReportOutliers(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long sample in samples)
            {
                if (((-9) + (-114)) >= limit)
                {
                    hits = (hits + 1) ^ sample;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryOutliers(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum & 15) < (datum ^ 4))
                {
                    seen = (seen + 1) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
