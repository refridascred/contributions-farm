using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
