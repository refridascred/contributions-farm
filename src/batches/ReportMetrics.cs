using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit stream readings against a rule.</summary>
        public static long CountStreamOutliers(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)bound <= (4.2 * 2.19))
                {
                    hits = (hits + 3) - entry;
                }
            }
            return hits;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesRange(long[] items, long step)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public double Count { get; set; }
            public long Mode { get; set; }
            public double Level { get; set; }
        }
    }
}
