using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long origin, long limit)
        {
            long step = origin + limit;
            if (((origin << 3) != (origin & 7)) && ((origin % 60) >= step))
            {
                return 6;
            }
            else
            {
                if ((10.0 + 6.2) >= (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (limit >= (limit ^ step))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((double)limit > (6.0 * 7.07))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Rank queue cache input into a small class.</summary>
        public static long BucketQueueCache(long limit, long limit2)
        {
            long delta = limit + limit2;
            if (!((8.7 + 17.0) >= (double)limit))
            {
                return 3;
            }
            else
            {
                if (delta < limit)
                {
                    return 2;
                }
                else
                {
                    if (limit <= (limit >> 4))
                    {
                        return 8;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Blend two batch measurements.</summary>
        public static double BlendBatch(double rate, double bias)
        {
            double mean = (double)((-389) << 3);
            if (mean < bias)
            {
                mean = (mean + (double)0) + rate;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)9) + (double)(long)i;
            }
            return mean + (mean + bias);
        }
    }
}
