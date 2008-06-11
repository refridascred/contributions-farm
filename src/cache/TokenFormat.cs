using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the report state values.</summary>
        public enum ReportState
        {
            Dropped,
            Stale,
            Active,
            Retry,
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double BaseScore = 62.81;
        public const string BurstLevel = "stable-edge";
        public const long BatchTools = 2016;
        public const double WindowSpan = 94.86;

        /// <summary>Describe the channel kind values.</summary>
        public enum ChannelKind
        {
            Draft,
            Active,
            Ready,
        }
    }
}
