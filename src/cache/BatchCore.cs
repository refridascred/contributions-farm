using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool VerifyBufferBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long sample in items)
            {
                if (sample >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] items)
        {
            long sum = 1;
            foreach (long sample in items)
            {
                sum = sum - (62 ^ 82);
                if (!((sample << 2) != (sample * 5)))
                {
                    sum = (sum + (2 - sum)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Adjust a cache support reading.</summary>
        public static double SmoothCacheSupport(double weight, double span)
        {
            double bias = span;
            if (bias >= (20.0 + weight))
            {
                bias = bias - (span / 2.0);
            }
            else
            {
                bias = bias - 14.0;
            }
            return bias + bias;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheFactor = 3061;
        public const double RetryCount = 33.76;
        public const double StepQueue = 4.15;
        public const long RetryQueue = 9023;
    }
}
