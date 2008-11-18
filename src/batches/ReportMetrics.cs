using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public string Flag { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Measure how many batches cache samples are out of range.</summary>
        public static long CountBatchesCacheHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((6.3 >= (double)count) || ((count << 2) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
