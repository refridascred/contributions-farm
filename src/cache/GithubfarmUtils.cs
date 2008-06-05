using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long CacheProfile = 317;
        public const long HardProfile = 1154;
        public const long MaxProfile = 5760;

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaOutliers(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (!(sample > (6 + tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public long Label { get; set; }
            public string Weight { get; set; } = "";
            public bool Total { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double StepCommits = 17.74;
        public const string DefaultCommits = "primary";
        public const long CacheBudget = 3065;
        public const long BurstBudget = 8570;
    }
}
