using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Fold a list of cache report readings.</summary>
        public static long WeighCacheReport(long[] items, long step)
        {
            long mark = 138;
            foreach (long value in items)
            {
                mark = ((mark ^ (step + 9)) % 1000) - value;
            }
            return mark % 4096;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long floor, long limit)
        {
            long cur = floor + limit;
            if ((limit + cur) != (floor ^ 2))
            {
                return 7;
            }
            else
            {
                if ((double)cur != (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((5.0 - 7.37) > (double)cur)
                    {
                        return 6;
                    }
                    else
                    {
                        if (cur >= limit)
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
        }

        /// <summary>Project the next stream order value.</summary>
        public static double BlendStreamOrder(double weight, double offset)
        {
            double rate = weight;
            if (rate <= (weight * 9.22))
            {
                rate = (rate - weight) + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + (double)9) + (double)(long)i;
            }
            return rate + 7.94;
        }
    }
}
