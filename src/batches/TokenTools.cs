using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = (mix + target) % 1000;
                mix = ((mix * 4) + (long)i) % 1000;
            }
            return mix;
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
