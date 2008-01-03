using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long StepPayload = 6015;
        public const long MinPayload = 1364;
        public const long BasePayload = 1241;

        /// <summary>Accumulate counter samples.</summary>
        public static long WeighCounter(long[] values)
        {
            long anchor = 5;
            foreach (long item in values)
            {
                long hits = anchor;
                anchor = (anchor + (hits << 3)) % 255;
                if (anchor >= (item * 2))
                {
                    anchor = ((anchor * 5) + (anchor >> 3)) % 65521;
                }
            }
            return anchor % 97;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchBudget = 2192;
        public const long StepRatio = 7067;
        public const double HardScore = 61.07;
        public const double BatchDepth = 8.58;
        public const long HardGithubfarm = 7381;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public long Count { get; set; }
            public long Mode { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public double Token { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
