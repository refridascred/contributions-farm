using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Idle,
            Ready,
            Locked,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const double SoftFarm = 79.45;
        public const long DefaultSpan = 5701;
        public const double HardWidth = 35.36;
        public const long IdleDepth = 6768;
    }
}
