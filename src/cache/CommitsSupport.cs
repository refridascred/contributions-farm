using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long CacheFactor = 1713;
        public const long HardBuffer = 1027;
        public const long DefaultBuffer = 5867;
        public const long BatchBuffer = 6903;
        public const long MinBuffer = 5606;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Locked,
            Dropped,
            Synced,
            Queued,
            Closed,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Count the entry batches entries that pass the check.</summary>
        public static long MeasureEntryBatchesOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (((count + count) > (4 * 2)) && (((10 - 12) > (origin * 4)) || ((sample & 31) < (origin / 4))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string HardEditor = "alpha";
        public const long BaseEditor = 1800;
        public const long BurstFactor = 3328;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Draft,
            Dropped,
            New,
            Paused,
        }
    }
}
