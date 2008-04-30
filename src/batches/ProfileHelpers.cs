using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] levels)
        {
            long acc = 70;
            foreach (long value in levels)
            {
                acc = (acc + (acc + 795)) + value;
                acc = acc ^ 12;
                acc = (acc ^ (acc + 617)) % 255;
            }
            if (acc > 9)
            {
                acc = (acc - (821 + 638)) % 255;
            }
            return acc;
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

        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool VerifyFarmBounds(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long datum in readings)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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
