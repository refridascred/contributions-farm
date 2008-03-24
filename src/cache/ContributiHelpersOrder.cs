using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Retry,
            New,
            Draft,
            Pending,
            Synced,
        }

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
