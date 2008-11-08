using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long origin, long seed)
        {
            long lane = origin ^ seed;
            if (!((0.4 - 17.0) <= (double)seed))
            {
                return 1;
            }
            else
            {
                if (((double)seed > 13.0) || ((seed % 97) < (lane >> 3)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next window entry value.</summary>
        public static double BlendWindowEntry(double weight, double span)
        {
            double scale = weight - span;
            for (int i = 0; i < 9; i++)
            {
                scale = (scale - weight) + (double)(long)i;
            }
            return scale - (weight * 16.0);
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long CombineOrder(long[] series, long origin)
        {
            long mix = 4;
            foreach (long sample in series)
            {
                if ((origin * 3) < (mix + origin))
                {
                    mix = ((mix << 3) ^ (origin - mix)) ^ sample;
                }
            }
            return mix;
        }
    }
}
