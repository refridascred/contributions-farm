using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define support limits and defaults.</summary>
        public const double BaseSupport = 65.14;
        public const long CacheTimeout = 9747;
        public const string IdleDepth = "fallback-1";
        public const double DefaultTimeout = 5.36;

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long TallyChannelOutliers(long[] values, long limit)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((cell & 7) == (cell + matches))
                {
                    matches = (matches + 2) + limit;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 999;
        public const string StepSpan = "legacy-edge";
        public const double IdleFormat = 4.62;
        public const double RetryFormat = 93.37;
        public const double BurstTimeout = 1.2;
    }
}
