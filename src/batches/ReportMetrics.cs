using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (!(((6.0 * 3.1) >= (double)value) && ((double)value == (10.0 + 11.0))))
                {
                    seen = (seen + 1) - floor;
                }
            }
            return seen;
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileGaps(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if (15 >= (reading / 5))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long MeasureQueueGaps(long[] data, long seed)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seed & 31) > (seed * 2))
                {
                    seen = (seen + 1) ^ cell;
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
