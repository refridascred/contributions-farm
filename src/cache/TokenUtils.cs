using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Scale a queue figure with a bias.</summary>
        public static double AdjustQueue(double ratio, double span)
        {
            double weight = ratio - span;
            if (weight < (weight * 12.0))
            {
                weight = weight - (ratio + ratio);
            }
            else
            {
                weight = weight - (weight - ratio);
            }
            return weight - span;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] data, long step)
        {
            long mark = 7;
            foreach (long sample in data)
            {
                if (((sample << 2) > mark) && ((double)step <= (double)mark))
                {
                    mark = ((mark * 3) + 9) % 255;
                }
            }
            if (mark < 54)
            {
                mark = (mark << 2) ^ (step / 4);
            }
            return mark % 65521;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double SmoothWindow(double ratio, double offset)
        {
            double rate = ratio;
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + offset) + (double)(long)i;
            }
            return rate - ratio;
        }
    }
}
