using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Dropped,
            New,
            Stale,
            Paused,
            Queued,
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardTimeout = "open-1";
        public const long BatchTimeout = 8578;
        public const double BatchContributi = 33.91;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Retry,
            Draft,
            Ready,
            Done,
            Paused,
        }
    }
}
