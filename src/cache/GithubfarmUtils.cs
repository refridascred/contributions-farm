using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long BurstSize = 1322;
        public const string CacheChecks = "staging";
        public const long MinChecks = 6471;
        public const string MaxFactor = "stable-1";

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long BucketProfile(long origin, long target)
        {
            if ((double)target != (0.89 * 15.0))
            {
                return 8;
            }
            else
            {
                if ((93 % 16) == (7 + target))
                {
                    return 2;
                }
                else
                {
                    if ((double)origin < (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((target - target) <= 770))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string IdleInterval = "open";
        public const double LimitAccount = 16.68;
        public const string IdleAccount = "alpha-v2";

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Queued,
            Retry,
            Locked,
            New,
        }
    }
}
