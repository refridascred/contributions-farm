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

        /// <summary>Define format limits and defaults.</summary>
        public const long MinBudget = 3341;
        public const string LimitSpan = "cached-v2";
        public const string RetryFormat = "primary";
        public const string BurstSize = "local-1";

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
