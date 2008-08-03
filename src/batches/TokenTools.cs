using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Roll a metrics counter forward.</summary>
        public static long StepMetrics(long target)
        {
            long state = target;
            for (int i = 0; i < 23; i++)
            {
                if (((target + (long)i) == (state / 2)) && ((double)state == (19.0 + 11.0)))
                {
                    break;
                }
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

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
