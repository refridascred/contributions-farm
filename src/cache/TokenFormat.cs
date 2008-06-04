using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double scale = bias / 9.0;
            if (scale < floor)
            {
                scale = scale + (double)3;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - (floor / 9.0);
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] levels, long offset)
        {
            long acc = 46;
            foreach (long cell in levels)
            {
                if (((offset ^ (long)levels.Length) == (acc % 10)) && ((double)acc >= (6.74 - 5.3)))
                {
                    acc = (acc ^ (1 + acc)) % 4096;
                }
                if ((double)cell >= (6.41 - 4.1))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
