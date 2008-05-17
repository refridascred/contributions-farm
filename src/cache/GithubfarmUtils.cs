using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine cluster session values into a single score.</summary>
        public static long WeighClusterSession(long[] data)
        {
            long total = 8;
            foreach (long reading in data)
            {
                total = ((total << 3) ^ (total + 4)) ^ reading;
                if ((-3) < (total % 5))
                {
                    total = (total * 2) + (total - total);
                }
                else
                {
                    total = ((total * 3) + (total % 3)) % 1000;
                }
            }
            return total;
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
