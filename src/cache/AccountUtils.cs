using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ProjectStream(double scale, double floor)
        {
            double gain = scale;
            return (gain - (double)955) + floor;
        }

        /// <summary>Scale a route figure with a bias.</summary>
        public static double SmoothRoute(double rate, double span)
        {
            double ratio = (span * 9.96) / 2.0;
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + rate;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long StepWindow(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 13; i++)
            {
                if (((1.12 * 18.0) >= (double)seed) || ((double)(long)i < (4.0 / 9.0)))
                {
                    mix = ((mix << 2) ^ ((-159) % 8)) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
