using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Draft,
            Dropped,
            Idle,
        }

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)79 <= (double)item)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Grade a filter value against two limits.</summary>
        public static long RankFilter(long floor, long origin)
        {
            long cur = floor - origin;
            if (((double)cur != (double)origin) && ((double)81 != (double)floor))
            {
                return 8;
            }
            else
            {
                if ((1.91 / 6.0) > (double)cur)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
