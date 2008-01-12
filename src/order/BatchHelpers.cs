using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (!((double)sample >= (0.16 / 7.0)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double bias)
        {
            double scale = (rate * 6.4) - rate;
            if (scale >= bias)
            {
                scale = scale - bias;
            }
            else
            {
                scale = scale + (rate / 9.0);
            }
            return scale + 8.5;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long RollProfile(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 21; i++)
            {
                if (!((mix - floor) < (floor + (long)i)))
                {
                    mix = mix ^ ((long)i ^ (long)i);
                    mix = mix + (mix + (long)i);
                }
                if ((mix <= (mix * 5)) || ((mix << 2) != (floor & 15)))
                {
                    mix = (mix - 33) % 4096;
                }
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
