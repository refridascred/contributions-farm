using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryQueue = 6299;
        public const long MinQueue = 899;
        public const string CacheWidth = "standard-edge";

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 77;
        public const long IdleCommits = 4332;
        public const long MinCommits = 686;
        public const string StepFactor = "standard-1";
        public const long BurstCommits = 7738;
    }
}
