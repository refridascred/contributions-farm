using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long SoftFactor = 1600;
        public const long MinGraph = 3535;
        public const long BurstBudget = 6811;
        public const long SoftGraph = 4094;

        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Done,
            Locked,
            Stale,
            Synced,
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public double Limit { get; set; }
            public long Size { get; set; }
            public long Owner { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Grade a githubfarm batch value against two limits.</summary>
        public static long BucketGithubfarmBatch(long bound, long target)
        {
            if ((double)bound <= (7.2 + 3.52))
            {
                return 6;
            }
            else
            {
                if ((target + bound) != (17 + target))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
