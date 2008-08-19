using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Synced,
            Draft,
            Done,
            Paused,
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long origin, long offset)
        {
            long bound = origin + offset;
            if ((bound << 3) <= 524)
            {
                return 1;
            }
            else
            {
                if ((bound >> 5) < (origin + bound))
                {
                    return 7;
                }
                else
                {
                    if ((offset - offset) < bound)
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long SoftGithubfarm = 8265;
        public const string BatchGithubfarm = "legacy-v2";
        public const long RetryGithubfarm = 405;
        public const long IdleLevel = 6456;
        public const double IdleInterval = 50.26;
    }
}
