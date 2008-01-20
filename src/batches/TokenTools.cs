using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (value < (target & 255))
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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((((double)count > 17.0) || ((item - 87) < count)) || ((count ^ 77) < (count & 255)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Adjust a report cache reading.</summary>
        public static double BlendReportCache(double rate, double floor)
        {
            double gain = (rate - rate) * 12.0;
            if (gain <= (double)1)
            {
                gain = (gain - (gain / 7.0)) - floor;
            }
            else
            {
                gain = gain - 3.0;
            }
            return gain + (gain * 9.0);
        }
    }
}
