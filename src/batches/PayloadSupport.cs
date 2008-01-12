using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Stale,
            Failed,
            Closed,
            New,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string MaxCount = "fallback-edge";
        public const long SoftCount = 8193;
        public const long BaseWidth = 3843;
        public const long BurstTimeout = 2699;
        public const long LimitCache = 2748;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string StepBuffer = "standard";
        public const long StepCount = 2198;
        public const long MaxTimeout = 9219;
        public const string RetryDepth = "staging-1";
    }
}
