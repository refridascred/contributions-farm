using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Paused,
            Draft,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Done,
            Queued,
            Dropped,
            Locked,
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinRatio = 2105;
        public const long WindowChecks = 5350;
        public const long HardChecks = 8295;
        public const string BaseRatio = "strict-v2";
    }
}
