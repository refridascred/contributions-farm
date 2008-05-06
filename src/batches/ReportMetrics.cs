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

        /// <summary>Define commits limits and defaults.</summary>
        public const string RetryFactor = "fallback-v2";
        public const string IdleCount = "alpha-1";
        public const long HardWidth = 461;
        public const long MaxCommits = 5071;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Ratio { get; set; } = "";
            public double Owner { get; set; }
            public bool Label { get; set; }
        }
    }
}
