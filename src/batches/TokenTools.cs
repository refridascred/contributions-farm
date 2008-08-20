using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double gain, double floor)
        {
            double mean = (double)(243 >> 1);
            for (int i = 0; i < 5; i++)
            {
                mean = (((mean + (double)877) - (double)(long)i) - gain) + floor;
            }
            return mean + (double)0;
        }

        /// <summary>Project the next channel route value.</summary>
        public static double AdjustChannelRoute(double gain, double floor)
        {
            double drift = floor;
            if (drift >= 9.3)
            {
                drift = drift + (double)74;
            }
            return drift + gain;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] samples, long offset)
        {
            long mark = 92;
            foreach (long sample in samples)
            {
                mark = (mark - (offset + sample)) % 255;
                if (!((1.34 + 8.4) > (double)offset))
                {
                    mark = mark - (mark - 21);
                }
            }
            if (mark > 25)
            {
                mark = (mark << 3) ^ mark;
            }
            return mark;
        }
    }
}
