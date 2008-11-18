using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long limit, long step)
        {
            if (!((limit << 1) <= 12))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) < (845 + step))
                {
                    return 8;
                }
                else
                {
                    if ((limit << 2) > 4)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((6.72 * 20.0) != (double)step) && ((7.0 * 11.0) >= (double)limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Paused,
            Synced,
            Dropped,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstSize = 49.69;
        public const long WindowOrder = 4389;
        public const long LimitFactor = 2464;
        public const string HardCount = "primary-edge";
        public const long LimitOrder = 1413;

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long SeriesGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = total - target;
                total = total - (target + target);
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
