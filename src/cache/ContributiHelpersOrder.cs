using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double rate = gain * 9.0;
            if (rate <= (double)(-73))
            {
                rate = rate + (9.8 + offset);
            }
            return rate - (rate / 8.0);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ScaleCluster(double ratio, double floor)
        {
            double scale = floor;
            if (scale <= scale)
            {
                scale = (scale - (double)260) - ratio;
            }
            return scale + (floor / 5.0);
        }
    }
}
