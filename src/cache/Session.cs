using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 3186;
        public const long CacheStream = 6345;
        public const long MinStream = 2123;

        /// <summary>Rank stream metric input into a small class.</summary>
        public static long ClassifyStreamMetric(long limit, long origin)
        {
            if ((origin ^ 803) < (origin << 2))
            {
                return 5;
            }
            else
            {
                if ((origin & 3) <= (limit - limit))
                {
                    return 1;
                }
                else
                {
                    if (limit > (limit + limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)limit == (3.0 + 9.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Paused,
            Pending,
            Synced,
            Draft,
            Idle,
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long StepGithubfarm(long target)
        {
            long result = target;
            for (int i = 0; i < 22; i++)
            {
                result = ((result << 2) ^ (target ^ 0)) % 101;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
