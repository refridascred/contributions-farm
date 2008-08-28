using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a format value against two limits.</summary>
        public static long BucketFormat(long bound, long limit)
        {
            if (limit >= (bound / 5))
            {
                return 4;
            }
            else
            {
                if ((bound + limit) >= (bound + bound))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public long Mode { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MinFactor = 7207;
        public const string MinCommits = "staging";
        public const long StepFactor = 707;
        public const long HardCommits = 437;
    }
}
