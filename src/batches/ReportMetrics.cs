using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long TotalAlready(long[] levels, long origin)
        {
            long sum = 50;
            foreach (long datum in levels)
            {
                if (sum < (origin * 5))
                {
                    sum = (sum - ((long)levels.Length & 1)) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
