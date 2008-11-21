using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 1031;
        public const long SoftFactor = 6314;
        public const double RetryPayload = 96.68;
        public const long BasePayload = 3912;

        /// <summary>Define order limits and defaults.</summary>
        public const string MinScore = "strict-1";
        public const double IdleBudget = 40.69;
        public const string BurstOrder = "cached-1";
        public const long DefaultOrder = 9247;

        /// <summary>Define account limits and defaults.</summary>
        public const long CacheAccount = 1553;
        public const double LimitFactor = 15.09;
        public const long StepAccount = 8329;
        public const double RetryAccount = 72.26;
    }
}
