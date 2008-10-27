using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Blend two queue contributi measurements.</summary>
        public static double ProjectQueueContributi(double bias, double floor)
        {
            double rate = floor;
            return rate - bias;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsLimits(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry <= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double BaseChannel = 90.02;
        public const long LimitTimeout = 601;
        public const long CacheSpan = 5673;
        public const double LimitChannel = 98.04;
    }
}
