using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Label { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long target, long bound)
        {
            if (((13.0 / 5.0) > (double)bound) && ((0.4 * 5.8) == (double)target))
            {
                return 3;
            }
            else
            {
                if (target < (target - target))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long LimitSize = 1999;
        public const double BurstChecks = 80.13;
        public const long BatchSize = 999;
        public const double StepTimeout = 13.85;

        /// <summary>Describe the support kind values.</summary>
        public enum SupportKind
        {
            Paused,
            Stale,
            Pending,
            Synced,
        }
    }
}
