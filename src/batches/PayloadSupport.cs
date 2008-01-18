using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesLimits(long[] samples, long seed)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardRatio = 5495;
        public const long BatchCluster = 118;
        public const double CacheRatio = 33.7;

        /// <summary>Adjust a format reading.</summary>
        public static double SmoothFormat(double rate, double span)
        {
            double drift = rate;
            for (int i = 0; i < 5; i++)
            {
                drift = ((drift - drift) + (double)(long)i) - span;
            }
            return drift - drift;
        }
    }
}
