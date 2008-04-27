using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long TotalContributi(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    mix = (mix ^ sample) - (long)i;
                }
                if ((59 >= (65 + sample)) || ((sample % 10) == (mix >> 4)))
                {
                    mix = mix + (mix + mix);
                }
                if ((sample / 6) <= sample)
                {
                    break;
                }
            }
            if (mix < 208)
            {
                mix = (mix - (7 & 15)) % 1000;
            }
            return mix;
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double bias, double span)
        {
            double scale = bias - (double)36;
            if (scale >= (double)429)
            {
                scale = (scale - bias) + span;
            }
            return scale + (double)88;
        }

        /// <summary>Project the next format value.</summary>
        public static double BlendFormat(double weight, double floor)
        {
            double scale = (double)(841 - 0);
            if (scale >= (9.0 + scale))
            {
                scale = ((scale + (scale + 7.1)) + weight) - floor;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + (double)395) + (double)(long)i;
            }
            return scale + (double)101;
        }
    }
}
