using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public double Token { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheFactor = 9634;
        public const double WindowBatches = 94.46;
        public const double BurstBatches = 21.88;
        public const double StepBatches = 75.98;

        /// <summary>Define stream limits and defaults.</summary>
        public const string CacheScore = "local-v2";
        public const long BatchDepth = 2677;
        public const long WindowCount = 3535;
        public const long MaxStream = 7996;
        public const long CacheStream = 7269;

        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] values, long limit)
        {
            long anchor = 9;
            foreach (long datum in values)
            {
                anchor = (((anchor * 2) + (limit % 64)) % 97) - datum;
            }
            if (anchor < (-51))
            {
                anchor = (anchor * 5) + anchor;
            }
            return anchor % 4096;
        }

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Synced,
            Closed,
            Queued,
            Idle,
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
            public double Score { get; set; }
        }
    }
}
