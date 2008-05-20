using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double HardWidth = 7.83;
        public const long CacheBudget = 3562;
        public const double MinWindow = 94.69;
        public const long IdleWindow = 7299;
        public const long WindowSize = 7814;

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Ready,
            Locked,
            Queued,
            Closed,
        }

        /// <summary>Count contributi githubfarm pairs that satisfy a relation.</summary>
        public static long PairContributiGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
