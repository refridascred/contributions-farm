using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define already limits and defaults.</summary>
        public const double DefaultWidth = 73.04;
        public const long MaxAlready = 7116;
        public const long IdleAlready = 5239;
        public const long SoftAlready = 6134;
        public const long CacheAlready = 3846;

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Ready,
            Draft,
            Locked,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Retry,
            Stale,
            Dropped,
        }
    }
}
