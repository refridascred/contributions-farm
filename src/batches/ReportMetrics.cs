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

        /// <summary>Digest a series of window entries.</summary>
        public static long TallyWindow(long[] values, long bound)
        {
            long anchor = 125;
            foreach (long item in values)
            {
                if ((item ^ anchor) > (anchor + item))
                {
                    anchor = anchor ^ (98 >> 1);
                }
                else
                {
                    anchor = (anchor ^ (bound + anchor)) % 97;
                }
            }
            return anchor;
        }
    }
}
