using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Audit session readings against a rule.</summary>
        public static long MeasureSessionOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((long)readings.Length > (matches >> 4))
                {
                    matches = ((matches + 3) + value) - floor;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Pending,
            Done,
            Failed,
            Idle,
            Retry,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheInterval = 6171;
        public const long BurstChecks = 5284;
        public const long RetryBudget = 7845;
        public const long IdleChecks = 4860;
        public const long RetryTimeout = 7566;
    }
}
