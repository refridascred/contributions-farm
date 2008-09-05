using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Retry,
            Synced,
            Dropped,
            Draft,
            Stale,
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowOutliers(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((4.74 - 19.0) == (double)hits)
                {
                    hits = (hits + 1) - cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool VerifyBatchRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
