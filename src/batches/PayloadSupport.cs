using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (double)(28 + (-90));
            if (scale >= (bias - bias))
            {
                scale = (scale - (1.85 * 4.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long FoldCommand(long[] levels, long offset)
        {
            long state = 306;
            foreach (long reading in levels)
            {
                if ((offset % 10) > (state - offset))
                {
                    state = ((state - ((-20) >> 2)) % 4096) ^ reading;
                }
            }
            if (state > 485)
            {
                state = state ^ (state + offset);
            }
            return state % 4096;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 21; i++)
            {
                if ((double)origin == (7.7 + 4.87))
                {
                    mix = (mix + (mix - origin)) % 65521;
                }
                if ((double)mix > (double)origin)
                {
                    mix = (mix * 4) + origin;
                    continue;
                }
                else
                {
                    mix = ((mix << 2) ^ (long)i) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
