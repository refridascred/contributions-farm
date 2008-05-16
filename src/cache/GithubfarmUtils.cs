using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Idle,
            Locked,
            Failed,
        }

        /// <summary>Grade a farm token value against two limits.</summary>
        public static long GradeFarmToken(long step, long seed)
        {
            if ((-242) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((seed + seed) < (seed + step))
                {
                    return 4;
                }
                else
                {
                    if (step <= (step + step))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((seed + 977) == (seed + step))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Paused,
            Retry,
            New,
            Queued,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long IdleSize = 44;
        public const long BurstProfile = 8683;
        public const long RetryInterval = 9705;
        public const long StepProfile = 5837;
    }
}
