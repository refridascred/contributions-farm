using System;

namespace Common.Utilities
{
    /// <summary>Order utils helpers.</summary>
    public static class OrderUtils
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double StepRecord = 67.71;
        public const double WindowFactor = 24.75;
        public const long DefaultRecord = 5129;
        public const double RetryCount = 65.83;
        public const string WindowBudget = "fallback-1";

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (double)count)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BurstCount = 5063;
        public const long BaseFormat = 906;
        public const long BatchFormat = 5149;
        public const double BaseSize = 0.1;
        public const long DefaultDepth = 5852;

        /// <summary>Describe the session status values.</summary>
        public enum SessionStatus
        {
            Active,
            Stale,
            New,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxCounter = 5494;
        public const long WindowCounter = 3139;
        public const long CacheCounter = 2781;
        public const double StepCounter = 80.59;
        public const long HardWidth = 3630;
    }
}
