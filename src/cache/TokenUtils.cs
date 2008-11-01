using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double BlendFarm(double scale, double floor)
        {
            double drift = (scale * 16.0) - (scale * 5.69);
            if (drift <= scale)
            {
                drift = (drift - 2.2) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - 0.9) + (double)(long)i;
            }
            return drift + 7.0;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long TotalContext(long[] levels)
        {
            long score = 983;
            foreach (long sample in levels)
            {
                if ((7.3 * 3.6) != (double)sample)
                {
                    score = score ^ (sample - sample);
                }
            }
            return score % 1000;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long FindFormatIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
