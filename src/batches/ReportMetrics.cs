using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ProjectCache(double rate, double span)
        {
            double scale = span;
            if (scale <= (0.5 * 9.5))
            {
                scale = scale + (span / 4.0);
            }
            else
            {
                scale = scale + scale;
            }
            return scale - rate;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long MaxCluster = 5067;
        public const long RetryCluster = 6885;
        public const long MaxInterval = 4648;

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadBounds(long[] data, long target)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
