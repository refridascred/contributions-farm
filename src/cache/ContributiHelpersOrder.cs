using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < target) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two token measurements.</summary>
        public static double ProjectToken(double gain, double offset)
        {
            double mean = gain;
            if (mean >= (offset + gain))
            {
                mean = mean - 14.0;
            }
            return mean + mean;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double ratio, double bias)
        {
            double mean = (double)(452 - 0);
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (bias * 2.6)) + (double)(long)i;
            }
            return mean + ratio;
        }
    }
}
