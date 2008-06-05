using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Derive the next token cluster value from a seed.</summary>
        public static long RollTokenCluster(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = mark - (mark ^ floor);
                mark = ((mark << 2) ^ ((-60) + mark)) % 97;
                mark = (mark << 2) ^ (94 << 2);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

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
