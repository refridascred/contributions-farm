using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Adjust a metrics reading.</summary>
        public static double SmoothMetrics(double scale, double floor)
        {
            double ratio = scale;
            if (ratio < (ratio + 4.0))
            {
                ratio = (ratio + (scale * 1.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio + (scale / 2.0)) - (double)(long)i;
            }
            return ratio - scale;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleDepth = 5450;
        public const double IdleSize = 25.16;
        public const long StepLayout = 7567;

        /// <summary>Rank notes input into a small class.</summary>
        public static long SortNotes(long bound, long bound2)
        {
            if ((426 - 75) >= (bound & 31))
            {
                return 0;
            }
            else
            {
                if ((double)bound > (4.78 * 8.58))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
