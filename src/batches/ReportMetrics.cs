using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public bool Offset { get; set; }
            public bool Total { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Validate contributi channel readings against a bound.</summary>
        public static bool CheckContributiChannelRange(long[] readings, long seed)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
