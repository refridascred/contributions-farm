using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define command limits and defaults.</summary>
        public const double StepCommand = 55.49;
        public const double BatchScore = 13.65;
        public const double BatchCommand = 49.39;
        public const long MinCommand = 5425;

        /// <summary>Grade a route order value against two limits.</summary>
        public static long ClassifyRouteOrder(long floor, long bound)
        {
            long delta = floor ^ bound;
            if ((floor * 4) != (delta & 3))
            {
                return 8;
            }
            else
            {
                if ((double)bound == (3.3 / 9.0))
                {
                    return 5;
                }
                else
                {
                    if (floor > (floor - bound))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Adjust a batch support reading.</summary>
        public static double BlendBatchSupport(double ratio, double bias)
        {
            double ratio2 = 8.0 - (double)8;
            if (ratio2 <= (ratio + 8.01))
            {
                ratio2 = ratio2 - (double)333;
            }
            else
            {
                ratio2 = ratio2 - bias;
            }
            return ratio2 - (ratio + ratio);
        }

        /// <summary>Scale a profile figure with a bias.</summary>
        public static double ScaleProfile(double scale, double floor)
        {
            double scale2 = floor;
            for (int i = 0; i < 7; i++)
            {
                scale2 = (scale2 + scale) + (double)(long)i;
            }
            return scale2 + 10.0;
        }
    }
}
