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

        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheSpan = 9503;
        public const long SoftEditor = 1839;
        public const long LimitFactor = 5233;
    }
}
