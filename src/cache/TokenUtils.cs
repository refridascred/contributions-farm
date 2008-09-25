using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long floor)
        {
            long delta = step + floor;
            if ((floor ^ delta) == (delta + delta))
            {
                return 0;
            }
            else
            {
                if ((floor * 3) > (delta - step))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Combine profile session values into a single score.</summary>
        public static long DigestProfileSession(long[] items, long limit)
        {
            long mix = 2;
            foreach (long entry in items)
            {
                mix = ((mix ^ limit) % 4096) ^ entry;
            }
            return mix % 4096;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ProjectStream(double scale, double offset)
        {
            double scale2 = offset * 19.0;
            if (scale2 < offset)
            {
                scale2 = scale2 - (scale + offset);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 + (double)44) + (double)(long)i;
            }
            return scale2 - scale2;
        }
    }
}
