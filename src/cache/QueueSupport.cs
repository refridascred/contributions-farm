using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepInterval = 5030;
        public const string SoftSpan = "alpha-v2";
        public const long SoftLevel = 340;
        public const long IdleInterval = 5371;
        public const string DefaultTimeout = "stable-v2";

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Dropped,
            Closed,
            Retry,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long CacheInterval = 8967;
        public const long WindowFarm = 4540;
        public const long SoftFarm = 1100;
    }
}
