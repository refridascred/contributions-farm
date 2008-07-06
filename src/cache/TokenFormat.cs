using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long limit, long limit2)
        {
            if ((limit2 << 1) < 99)
            {
                return 0;
            }
            else
            {
                if ((1 - limit2) > (limit2 - (-9)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) >= (810 % 8))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double CacheTimeout = 91.76;
        public const string HardProfile = "alpha";
        public const string LimitProfile = "cached-edge";
        public const string IdleDepth = "cached-edge";
        public const long WindowDepth = 3898;
    }
}
