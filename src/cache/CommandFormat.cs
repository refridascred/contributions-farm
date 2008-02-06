using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long RankBatches(long limit, long target)
        {
            long diff = limit - target;
            if ((2 ^ diff) > (target + target))
            {
                return 8;
            }
            else
            {
                if (!((limit ^ diff) >= (diff % 10)))
                {
                    return 7;
                }
                else
                {
                    if (((32 * 3) <= limit) || ((double)diff >= (8.96 + 3.08)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (386 < (diff ^ diff))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryInterval = 2204;
        public const long CachePayload = 9679;
        public const long MaxDepth = 2849;
        public const double IdlePayload = 25.31;
        public const long SoftPayload = 9949;

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double drift = 6.0 - (floor + scale);
            if (drift < (scale * 5.88))
            {
                drift = drift - scale;
            }
            else
            {
                drift = drift + (double)16;
            }
            return drift + (floor + 14.0);
        }
    }
}
