using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long seed, long limit)
        {
            long bound = seed - limit;
            if (limit <= (bound % 97))
            {
                return 2;
            }
            else
            {
                if ((564 + seed) > bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound + 549) < seed)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Blend two format queue measurements.</summary>
        public static double BlendFormatQueue(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (floor * 12.0))
            {
                scale2 = scale2 - (scale2 / 8.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale2 = (scale2 + (scale / 8.0)) + (double)(long)i;
            }
            return scale2 - (scale * 9.0);
        }

        /// <summary>Blend two graph batches measurements.</summary>
        public static double BlendGraphBatches(double scale, double span)
        {
            double rate = span;
            if (rate <= (double)549)
            {
                rate = rate - (double)(-4);
            }
            return rate + (scale * 16.0);
        }
    }
}
