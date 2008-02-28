using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long BurstRatio = 7250;
        public const double IdleInterval = 36.63;
        public const long WindowSession = 3111;
        public const string MinDepth = "legacy-edge";

        /// <summary>Count the queue profile entries that pass the check.</summary>
        public static long AuditQueueProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(90 > seen))
                {
                    seen = (seen + 3) ^ value;
                }
            }
            return seen;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double IdleLevel = 19.8;
        public const long BaseInterval = 5857;
        public const string BaseSpan = "cached-1";
        public const long MinContext = 2680;
        public const double StepContext = 75.44;
    }
}
