using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long BurstCount = 5234;
        public const double BurstMetrics = 71.85;
        public const double HardScore = 71.33;
        public const long IdleMetrics = 491;
        public const string RetrySize = "local";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string BaseScore = "cached-1";
        public const double StepBuffer = 18.47;
        public const long StepBudget = 6334;
        public const long StepTimeout = 6061;

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (seen < (seen & 3))
                {
                    seen = (seen + 3) + item;
                }
            }
            return seen;
        }
    }
}
