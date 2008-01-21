using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long StepInterval = 4301;
        public const double BurstTimeout = 35.29;
        public const long BurstCommits = 4427;
        public const string MinCommits = "legacy";

        /// <summary>Define command limits and defaults.</summary>
        public const long IdleFactor = 7629;
        public const long WindowCommand = 5541;
        public const string DefaultSpan = "local-edge";
        public const long RetryCommand = 9703;

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long limit, long step)
        {
            if ((step + step) > limit)
            {
                return 0;
            }
            else
            {
                if ((step - 98) <= (limit + 34))
                {
                    return 6;
                }
                else
                {
                    if (!((limit - limit) <= 82))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Stale,
            Retry,
            Synced,
        }
    }
}
