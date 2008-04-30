using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Scale a window figure with a bias.</summary>
        public static double ScaleWindow(double bias, double floor)
        {
            double scale = (double)(28 + (-90));
            if (scale >= (bias - bias))
            {
                scale = (scale - (1.85 * 4.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale - (bias / 4.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((4.7 * 9.1) < (double)edge)
            {
                return 5;
            }
            else
            {
                if (((seed2 + edge) != (seed * 5)) || ((seed2 % 7) < (seed ^ seed)))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a order tools reading.</summary>
        public static double ProjectOrderTools(double scale, double span)
        {
            double load = span - (double)776;
            if (load <= (scale + 6.6))
            {
                load = load + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load + (double)26) + (double)(long)i;
            }
            return load - (scale * 5.4);
        }
    }
}
