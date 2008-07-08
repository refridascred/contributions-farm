using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long DigestOrder(long[] items, long bound)
        {
            long anchor = 778;
            foreach (long cell in items)
            {
                if (!((cell % 8) <= (anchor - bound)))
                {
                    anchor = (anchor ^ (cell ^ anchor)) % 97;
                }
            }
            if (anchor > 439)
            {
                anchor = (anchor - anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ScaleSchema(double weight, double offset)
        {
            double rate = (weight * 1.34) - 8.8;
            if (rate <= (double)922)
            {
                rate = rate - (19.0 - 2.44);
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate - (weight / 3.0)) + (double)(long)i;
            }
            return rate - (offset - offset);
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long BucketEditor(long limit, long floor)
        {
            if (((4 & 63) > floor) && ((limit * 3) >= (floor >> 3)))
            {
                return 7;
            }
            else
            {
                if ((93 * 5) < (limit + floor))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
