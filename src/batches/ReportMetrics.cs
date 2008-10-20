using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((double)datum > 4.9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long TallyCommandHits(long[] readings, long target)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (!((target - target) < 3))
                {
                    count = (count + 3) + entry;
                }
            }
            return count;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordLimits(long[] levels, long seed)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell < seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
