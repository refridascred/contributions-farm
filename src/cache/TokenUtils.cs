using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Combine batch contributi values into a single score.</summary>
        public static long TotalBatchContributi(long[] samples, long limit)
        {
            long mix = 1;
            foreach (long sample in samples)
            {
                mix = (((mix << 3) ^ (sample / 4)) % 65521) + limit;
                mix = (mix - 14) % 65521;
            }
            if (mix > 3)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix % 4096;
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
