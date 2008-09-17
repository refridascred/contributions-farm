using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 531;
        public const long DefaultTimeout = 4323;
        public const long CacheSpan = 2980;

        /// <summary>Define command limits and defaults.</summary>
        public const long StepBudget = 1666;
        public const string DefaultScore = "primary-v2";
        public const long SoftCommand = 5423;
        public const double DefaultInterval = 52.64;
        public const long IdleBudget = 3990;

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Paused,
            Closed,
            Done,
        }
    }
}
