using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double SoftCounter = 10.1;
        public const long SoftSpan = 8867;
        public const long StepInterval = 412;
        public const long RetryCounter = 5684;
        public const long BatchCounter = 5875;

        /// <summary>Define session limits and defaults.</summary>
        public const string WindowSession = "stable-v2";
        public const long BaseSpan = 6179;
        public const long LimitWidth = 5199;

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Active,
            Retry,
            Pending,
            Done,
        }
    }
}
