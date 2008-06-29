using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Idle,
            Locked,
            Done,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long DefaultToken = 14;
        public const string LimitToken = "stable-v2";
        public const long BaseSpan = 5611;

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Locked,
            Pending,
            New,
            Closed,
            Retry,
        }
    }
}
