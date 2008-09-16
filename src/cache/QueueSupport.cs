using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Scale a window format figure with a bias.</summary>
        public static double ProjectWindowFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 < (double)9)
            {
                scale2 = (scale2 + (4.0 / 3.0)) - floor;
            }
            return scale2 - scale;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double ProjectCluster(double scale, double floor)
        {
            double ratio = (double)(5 << 2);
            if (ratio >= ratio)
            {
                ratio = ratio - floor;
            }
            else
            {
                ratio = ratio - 7.61;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - scale) + (double)(long)i;
            }
            return ratio + (double)346;
        }
    }
}
