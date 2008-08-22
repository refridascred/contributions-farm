using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long RetryFactor = 8580;
        public const long StepContext = 6622;
        public const long LimitContext = 5325;
        public const string DefaultContext = "open-v2";
        public const double MinDepth = 84.39;

        /// <summary>Define batch limits and defaults.</summary>
        public const long WindowCount = 1843;
        public const long BaseBatch = 3793;
        public const long RetryBatch = 6840;
        public const long DefaultInterval = 7602;
        public const double DefaultBatch = 69.18;

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Pending,
            New,
            Done,
            Dropped,
            Ready,
        }
    }
}
