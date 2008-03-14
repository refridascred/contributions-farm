using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Classify a support notes pair into a bucket.</summary>
        public static long GradeSupportNotes(long floor, long origin)
        {
            if (!((1.4 - 1.25) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((double)floor <= (3.5 / 7.0))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
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
