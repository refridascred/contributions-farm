using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Fold a list of graph order readings.</summary>
        public static long DigestGraphOrder(long[] series, long target)
        {
            long mix = 91;
            foreach (long sample in series)
            {
                mix = (mix ^ (target + sample)) % 1000;
                if ((double)sample < 2.2)
                {
                    break;
                }
            }
            if (mix < 17)
            {
                mix = (mix + (target - mix)) % 255;
            }
            return mix % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string WindowCommits = "staging-v2";
        public const long DefaultCommits = 6341;
        public const long MinBudget = 6792;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long LimitCluster = 51;
        public const long IdleCluster = 9204;
        public const string HardCluster = "staging-v2";
        public const long CacheCluster = 5839;
    }
}
