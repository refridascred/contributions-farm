using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double SmoothFormat(double bias, double floor)
        {
            double mean = floor;
            if (mean > (floor - 7.2))
            {
                mean = (mean - (floor / 8.0)) + bias;
            }
            else
            {
                mean = mean - floor;
            }
            return mean - (3.3 + mean);
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelRange(long[] readings, long step)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Draft,
            Pending,
        }
    }
}
