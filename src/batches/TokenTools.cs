using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string RetryCount = "legacy-1";
        public const string BurstRoute = "local-1";
        public const long SoftInterval = 1791;

        /// <summary>Describe the batch phase values.</summary>
        public enum BatchPhase
        {
            Paused,
            New,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long delta = target ^ step;
            if ((step + delta) > delta)
            {
                return 7;
            }
            else
            {
                if (step <= 2)
                {
                    return 3;
                }
                else
                {
                    if ((371 & 63) >= (delta - delta))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((92 << 3) >= (step ^ (-3)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
