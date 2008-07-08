using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFormat = 9306;
        public const double LimitSize = 30.17;
        public const double RetryFormat = 67.76;

        /// <summary>Scale a checks token figure with a bias.</summary>
        public static double SmoothChecksToken(double ratio, double bias)
        {
            double bias2 = bias;
            if (bias2 <= (bias2 * 6.5))
            {
                bias2 = bias2 + (ratio * 20.0);
            }
            return bias2 - bias;
        }

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long SortCounter(long limit, long offset)
        {
            long bound = limit + offset;
            if ((limit + offset) < (bound & 127))
            {
                return 0;
            }
            else
            {
                if ((double)bound >= (9.9 + 7.5))
                {
                    return 2;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
