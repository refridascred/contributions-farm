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

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftContext = "standard-v2";
        public const string CacheBudget = "staging-1";
        public const double LimitCount = 65.64;
        public const long IdleFactor = 8933;
    }
}
