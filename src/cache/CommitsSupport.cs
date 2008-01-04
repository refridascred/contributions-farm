using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8715;
        public const long MinFactor = 14;
        public const double HardSize = 19.83;

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public long Level { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleProfile = 60.34;
        public const string MaxDepth = "open-v2";
        public const string LimitWidth = "standard";
        public const double WindowProfile = 43.16;
        public const long RetryProfile = 1516;

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardGithubfarm = 9432;
        public const long SoftLevel = 9715;
        public const string BatchBudget = "primary";
        public const string DefaultGithubfarm = "stable";
        public const long StepLevel = 1592;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] readings)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((double)reading < (6.7 + 2.92))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long MaxFarm = 7589;
        public const string RetryFactor = "legacy-v2";
        public const double BatchFarm = 16.65;
        public const long BurstWidth = 1490;
    }
}
