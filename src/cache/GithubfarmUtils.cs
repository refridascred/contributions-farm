using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBudget = 2635;
        public const long MinRatio = 6198;
        public const long RetryBudget = 8875;
        public const long WindowScore = 5220;

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Offset { get; set; }
            public double Rank { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphOutliers(long[] levels, long offset)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((offset + 695) != (datum >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
