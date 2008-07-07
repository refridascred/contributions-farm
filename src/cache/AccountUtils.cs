using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricOutliers(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (18.0 > (double)hits)
                {
                    hits = ((hits + 1) ^ value) - limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Done,
            Retry,
            Queued,
            Closed,
            Dropped,
        }

        /// <summary>Check that every tools counter entry stays within the limit.</summary>
        public static bool VerifyToolsCounterBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long item in series)
            {
                if (item != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
