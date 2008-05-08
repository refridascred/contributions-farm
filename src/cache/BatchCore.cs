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

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Region { get; set; } = "";
            public double Total { get; set; }
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
