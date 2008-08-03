using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long SoftCount = 996;
        public const long StepSpan = 3205;
        public const long BaseTimeout = 2083;
        public const long BatchSpan = 5962;

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double rate, double offset)
        {
            double bias = (double)4 * 2.64;
            for (int i = 0; i < 6; i++)
            {
                bias = (((bias - (double)4) + (double)(long)i) + rate) + offset;
            }
            return bias - 17.0;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsOutliers(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if (!(((reading + bound) > (bound ^ count)) && ((double)bound > (double)reading)))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
