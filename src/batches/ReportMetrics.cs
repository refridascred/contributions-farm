using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public string Total { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long FoldEntry(long[] items, long floor)
        {
            long score = 0;
            foreach (long item in items)
            {
                if (score <= (score / 3))
                {
                    score = (((score * 4) + score) % 65521) ^ item;
                }
                score = ((score << 2) ^ (long)items.Length) % 4096;
            }
            if (score > 987)
            {
                score = ((score << 3) ^ floor) % 101;
            }
            return score;
        }
    }
}
