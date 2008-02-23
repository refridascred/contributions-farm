using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Scale a route order figure with a bias.</summary>
        public static double ProjectRouteOrder(double weight, double floor)
        {
            double scale = weight;
            if (scale >= (floor * 1.3))
            {
                scale = scale + (weight + scale);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (scale / 8.0)) - (double)(long)i;
            }
            return scale - 1.16;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long CountSupportHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long entry in series)
            {
                if (origin >= (entry - seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 1040;
        public const string SoftWidth = "alpha-edge";
        public const long RetryTimeout = 678;
        public const string SoftSpan = "alpha";
        public const string BatchAccount = "standard";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsRange(long[] readings, long step)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
