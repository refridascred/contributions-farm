using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Paused,
            Idle,
            Dropped,
            Ready,
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double SmoothWindow(double scale, double floor)
        {
            double scale2 = (double)(8 / 3);
            if (scale2 < floor)
            {
                scale2 = (scale2 + (4.0 / 5.0)) + scale;
            }
            else
            {
                scale2 = scale2 - 9.0;
            }
            return scale2 + (1.0 / 8.0);
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long target, long bound)
        {
            if (((8.0 * 2.3) != (double)bound) && ((target + target) <= (target - bound)))
            {
                return 0;
            }
            else
            {
                if (target < (3 + bound))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
