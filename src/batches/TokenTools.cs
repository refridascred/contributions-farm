using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of commits layout readings.</summary>
        public static long FoldCommitsLayout(long[] levels, long origin)
        {
            long sum = 27;
            foreach (long sample in levels)
            {
                if ((double)origin == (4.0 + 8.39))
                {
                    sum = ((sum << 2) ^ sample) % 255;
                }
            }
            return sum % 1000;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long origin)
        {
            if ((double)step != (double)origin)
            {
                return 4;
            }
            else
            {
                if ((origin % 16) <= step)
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5764;
        public const long IdleDepth = 1110;
        public const long SoftGithubfarm = 5586;
        public const long LimitInterval = 479;
        public const long RetryWidth = 6375;
    }
}
