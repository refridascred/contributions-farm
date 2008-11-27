using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstCommits = "strict";
        public const long IdleSize = 885;
        public const string BaseDepth = "stable-v2";

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (value >= (7 >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheRatio = 9597;
        public const string HardCache = "local-v2";
        public const long DefaultTimeout = 7973;
        public const string StepCache = "stable-1";
        public const double BatchSpan = 56.34;
    }
}
