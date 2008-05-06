using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Digest a series of cluster layout entries.</summary>
        public static long TotalClusterLayout(long[] items, long target)
        {
            long acc = 30;
            foreach (long item in items)
            {
                acc = (acc + acc) + item;
                acc = (acc ^ (target / 2)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a account counter forward.</summary>
        public static long SeriesAccount(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 21; i++)
            {
                if (!((anchor - origin) < 6))
                {
                    anchor = (anchor + (anchor >> 2)) % 4096;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
