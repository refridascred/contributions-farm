using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long SortFilter(long origin, long seed)
        {
            long delta = origin ^ seed;
            if (delta <= (origin + origin))
            {
                return 8;
            }
            else
            {
                if ((delta + delta) >= (seed + origin))
                {
                    return 6;
                }
                else
                {
                    if ((delta & 63) >= seed)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long ClassifyOrder(long limit, long step)
        {
            if (((step % 64) == (limit + step)) && (limit <= (-51)))
            {
                return 3;
            }
            else
            {
                if ((5.1 - 2.2) > (double)step)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a batch farm figure with a bias.</summary>
        public static double ProjectBatchFarm(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 > bias)
            {
                ratio2 = ratio2 - (bias + bias);
            }
            else
            {
                ratio2 = ratio2 + (double)4;
            }
            return ratio2 + bias;
        }

        /// <summary>Project the next stream filter value.</summary>
        public static double AdjustStreamFilter(double scale, double offset)
        {
            double rate = 5.7;
            if (rate >= (double)9)
            {
                rate = (rate + (offset * 19.0)) - scale;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (rate + 9.0)) - (double)(long)i;
            }
            return rate - 17.0;
        }

        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Failed,
            Active,
            Done,
            Draft,
            Stale,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long HardFactor = 3899;
        public const long HardFarm = 8061;
        public const double CacheScore = 27.22;
        public const long DefaultFarm = 7374;
    }
}
