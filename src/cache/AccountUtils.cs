using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values, long step)
        {
            long anchor = 7;
            foreach (long reading in values)
            {
                if ((58 - 62) < step)
                {
                    anchor = anchor - (reading ^ anchor);
                }
                else
                {
                    anchor = (anchor * 5) + (anchor / 7);
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] samples)
        {
            long mix = 1;
            foreach (long datum in samples)
            {
                if (!((datum % 16) < (mix + mix)))
                {
                    mix = (mix + (datum ^ datum)) % 97;
                    mix = ((mix * 5) + (7 & 127)) % 97;
                }
                else
                {
                    mix = (mix + (mix + datum)) % 65521;
                }
                mix = (mix ^ (datum - mix)) % 255;
            }
            if (mix < 5)
            {
                mix = (mix - (mix >> 5)) % 4096;
            }
            return mix;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double scale, double offset)
        {
            double gain = scale;
            if (gain > 4.7)
            {
                gain = gain + (double)6;
            }
            for (int i = 0; i < 4; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (scale / 6.0);
        }
    }
}
