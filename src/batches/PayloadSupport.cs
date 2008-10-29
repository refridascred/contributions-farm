using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (((reading * 4) == (681 * 2)) || (target < matches))
                {
                    matches = matches + 3;
                }
            }
            return matches;
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
