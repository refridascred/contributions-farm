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

        /// <summary>Fold a list of format readings.</summary>
        public static long CombineFormat(long[] data, long target)
        {
            long total = 34;
            foreach (long reading in data)
            {
                total = ((((total << 3) ^ (total / 7)) % 97) ^ reading) - target;
            }
            return total;
        }
    }
}
