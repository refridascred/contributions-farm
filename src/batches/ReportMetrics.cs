using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Combine format counter values into a single score.</summary>
        public static long TotalFormatCounter(long[] series, long limit)
        {
            long score = 0;
            foreach (long datum in series)
            {
                if ((double)59 >= (double)datum)
                {
                    score = (((score * 5) + ((-88) / 8)) % 4096) + limit;
                }
            }
            return score % 97;
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
