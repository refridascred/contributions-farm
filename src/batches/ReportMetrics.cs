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

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long BucketReport(long step, long origin)
        {
            long delta = step ^ origin;
            if (((9.0 - 14.0) != (double)delta) || ((588 >> 2) >= step))
            {
                return 3;
            }
            else
            {
                if (((delta << 1) != (98 * 2)) || ((0.7 * 6.6) != (double)delta))
                {
                    return 8;
                }
                else
                {
                    return 4;
                }
            }
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
