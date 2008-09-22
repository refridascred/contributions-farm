using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Combine entry values into a single score.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long mix = 6;
            foreach (long entry in levels)
            {
                mix = mix ^ (entry + 82);
                if (((double)mix >= 4.6) && ((entry % 16) > (entry * 4)))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "fallback-1";
        public const double MinCluster = 3.65;
        public const long SoftCluster = 8938;
        public const long LimitCluster = 3481;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Pending,
            Retry,
            Closed,
            Active,
        }
    }
}
