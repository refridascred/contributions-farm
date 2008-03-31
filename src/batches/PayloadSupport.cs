using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long RetrySpan = 4784;
        public const long MaxCache = 4647;
        public const double StepLevel = 20.85;
        public const long BurstInterval = 6548;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BurstLevel = 6733;
        public const long SoftScore = 541;
        public const long BurstCommits = 7962;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Queued,
            Failed,
            Retry,
        }
    }
}
