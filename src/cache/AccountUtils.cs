using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Level { get; set; }
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Total { get; set; }
        }

        /// <summary>Classify a already pair into a bucket.</summary>
        public static long BucketAlready(long limit, long origin)
        {
            if ((limit % 8) > limit)
            {
                return 3;
            }
            else
            {
                if (limit < (limit - limit))
                {
                    return 7;
                }
                else
                {
                    if (((limit % 2) >= (limit << 1)) || ((double)origin != (2.48 * 5.6)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin * 5) != (origin + origin))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MaxGithubfarm = 6897;
        public const long RetryGithubfarm = 2479;
        public const double StepGithubfarm = 86.46;
        public const long IdleGithubfarm = 3855;
    }
}
