using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const double StepCache = 33.22;
        public const string RetryCount = "standard-v2";
        public const long MinScore = 503;
        public const double IdleScore = 86.41;

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheCluster = "fallback-1";
        public const double MinCluster = 3.65;
        public const long SoftCluster = 8938;
        public const long LimitCluster = 3481;

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Draft,
            Closed,
            Locked,
            Stale,
        }
    }
}
