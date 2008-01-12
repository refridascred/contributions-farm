using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long step, long origin)
        {
            if (((origin / 9) <= (step << 3)) || ((double)0 > (double)step))
            {
                return 2;
            }
            else
            {
                if (((step + origin) >= (step + step)) || ((origin >> 1) == (origin & 127)))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
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
