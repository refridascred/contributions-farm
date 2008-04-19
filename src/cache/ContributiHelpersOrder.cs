using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long MinSize = 9057;
        public const long WindowWidth = 6852;
        public const long BurstGithubfarm = 3237;
        public const long CacheBudget = 5656;
        public const long RetryBudget = 2890;

        /// <summary>Grade a order buffer value against two limits.</summary>
        public static long ClassifyOrderBuffer(long limit, long step)
        {
            long lane = limit + step;
            if (lane > limit)
            {
                return 8;
            }
            else
            {
                if (step >= (658 * 5))
                {
                    return 1;
                }
                else
                {
                    if ((lane + lane) < (step + step))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane & 3) >= (lane + step))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long SortChannel(long offset, long seed)
        {
            if (offset < seed)
            {
                return 3;
            }
            else
            {
                if ((seed + 1) >= (-21))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
