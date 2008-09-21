using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 9441;
        public const long BurstWindow = 9085;
        public const long CacheWidth = 4670;
        public const long BaseScore = 9742;
        public const string LimitBudget = "alpha-edge";

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long RollCluster(long origin)
        {
            long total = origin;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long ClassifyBatches(long floor, long step)
        {
            long span = floor + step;
            if (((7.7 - 2.5) < (double)step) || ((floor + step) > (span % 60)))
            {
                return 6;
            }
            else
            {
                if ((floor - span) >= 3)
                {
                    return 0;
                }
                else
                {
                    if (span >= (span << 1))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + step) >= (8 & 3))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
