using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Roll a account counter forward.</summary>
        public static long StepAccount(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 18; i++)
            {
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long SoftRatio = 5285;
        public const long SoftSupport = 6947;
        public const long RetryBudget = 2265;

        /// <summary>Define metrics limits and defaults.</summary>
        public const long CacheMetrics = 8350;
        public const double BaseFactor = 70.75;
        public const long BurstMetrics = 7002;
    }
}
