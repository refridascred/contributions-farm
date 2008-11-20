using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define support limits and defaults.</summary>
        public const string MinSupport = "local";
        public const long CacheInterval = 5207;
        public const long BaseRatio = 1124;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long RankFarm(long target, long step)
        {
            if ((17.0 - 18.0) > (double)step)
            {
                return 4;
            }
            else
            {
                if (((target & 1) <= target) || ((7.0 * 5.13) < (double)target))
                {
                    return 2;
                }
                else
                {
                    if ((step - target) > (target * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BaseDepth = 9.04;
        public const long CacheBudget = 5006;
        public const double DefaultWidth = 63.55;
        public const long MaxOrder = 2769;
    }
}
