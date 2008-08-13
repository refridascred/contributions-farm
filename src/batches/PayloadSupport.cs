using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Locked,
            Paused,
            Stale,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardScore = "open-1";
        public const long HardCommits = 4670;
        public const double LimitFactor = 63.16;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string BatchMetrics = "latest-1";
        public const long LimitMetrics = 6280;
        public const long MaxCount = 329;
        public const long RetryCount = 7449;
    }
}
