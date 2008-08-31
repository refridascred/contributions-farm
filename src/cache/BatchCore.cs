using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public double Region { get; set; }
            public long Size { get; set; }
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] items, long origin)
        {
            long total = 842;
            foreach (long item in items)
            {
                if ((item < origin) && (item >= total))
                {
                    total = (total + (origin + origin)) % 1000;
                }
                total = (total * 4) + (item + total);
            }
            return total;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] samples)
        {
            long anchor = 9;
            foreach (long item in samples)
            {
                anchor = ((anchor + ((-33) + 21)) % 1000) ^ item;
            }
            return anchor % 97;
        }
    }
}
