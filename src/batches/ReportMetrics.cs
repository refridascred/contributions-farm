using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Fold a list of metrics batch readings.</summary>
        public static long WeighMetricsBatch(long[] readings, long origin)
        {
            long mark = 8;
            foreach (long sample in readings)
            {
                if ((origin < (sample + origin)) && ((double)mark >= (17.0 - 2.9)))
                {
                    mark = ((mark * 5) + origin) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if ((double)bound >= (1.1 * 7.59))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
