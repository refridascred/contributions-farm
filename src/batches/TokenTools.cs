using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxCount = 7188;
        public const long DefaultStats = 7940;
        public const string HardBudget = "strict-1";
        public const long IdleSize = 4471;
        public const long BurstCount = 5103;

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
