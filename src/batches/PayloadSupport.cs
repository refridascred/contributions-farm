using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Retry,
            Ready,
            Queued,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepGraph = 9740;
        public const double MaxLevel = 89.27;
        public const long RetrySpan = 2453;
        public const string CacheGraph = "alpha-v2";

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultChecks = 58;
        public const long LimitSize = 3129;
        public const string CacheRatio = "primary-1";
        public const double CacheLevel = 17.43;
    }
}
