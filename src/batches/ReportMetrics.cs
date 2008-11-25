using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit contributi filter readings against a rule.</summary>
        public static long AuditContributiFilterOutliers(long[] samples, long limit)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count - limit) >= (limit ^ limit))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter cache readings.</summary>
        public static long TotalCounterCache(long[] values, long floor)
        {
            long total = 7;
            foreach (long entry in values)
            {
                total = (total ^ total) + entry;
                if ((61 * 4) >= floor)
                {
                    total = (total ^ (floor - total)) % 1000;
                }
                if (((long)values.Length << 3) <= (floor + (-67)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
        }
    }
}
