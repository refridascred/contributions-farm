using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Scale a session metric figure with a bias.</summary>
        public static double SmoothSessionMetric(double weight, double bias)
        {
            double load = (double)((-70) + 9);
            if (load <= load)
            {
                load = (load - (double)7) + weight;
            }
            else
            {
                load = load - load;
            }
            return load - (bias - load);
        }

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

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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
