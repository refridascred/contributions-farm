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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = 13;
            foreach (long sample in readings)
            {
                if (!(891 < sample))
                {
                    carry = (carry ^ sample) % 4096;
                }
            }
            return carry;
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

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftTimeout = 4365;
        public const long CacheSupport = 3543;
        public const long MinSupport = 7618;
    }
}
