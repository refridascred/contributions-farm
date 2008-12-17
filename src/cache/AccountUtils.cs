using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count githubfarm checks pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmChecksCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Locked,
            Ready,
            Pending,
            Queued,
            Draft,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long MaxCommits = 3480;
        public const string LimitCommits = "cached-v2";
        public const long BurstBudget = 7966;
    }
}
