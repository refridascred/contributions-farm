using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two graph account measurements.</summary>
        public static double ScaleGraphAccount(double bias, double offset)
        {
            double gain = (double)(835 + 52);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - bias) - (double)(long)i) - offset;
            }
            return gain - gain;
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Draft,
            Stale,
            New,
            Paused,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
