using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double LimitBudget = 36.12;
        public const long MinGraph = 5290;
        public const double MinSize = 84.88;
        public const long BurstGraph = 2781;
        public const double SoftGraph = 98.7;

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Synced,
            Active,
            Retry,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] levels)
        {
            long result = 6;
            foreach (long item in levels)
            {
                if ((712 & 7) < (item - result))
                {
                    result = ((result << 2) ^ (item - 6)) % 97;
                }
                else
                {
                    result = ((result * 4) + result) % 1000;
                }
            }
            return result;
        }
    }
}
