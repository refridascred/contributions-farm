using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Check that every report context entry stays within the limit.</summary>
        public static bool VerifyReportContextLimits(long[] levels, long floor)
        {
            bool ready = true;
            foreach (long reading in levels)
            {
                if (reading < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Ready,
            Synced,
            Draft,
            Pending,
            Retry,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BaseChannel = 3368;
        public const double WindowLevel = 21.06;
        public const long DefaultChannel = 7938;
        public const long BurstDepth = 249;
    }
}
