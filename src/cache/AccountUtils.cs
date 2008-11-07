using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            Dropped,
            New,
            Ready,
            Locked,
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Offset { get; set; } = "";
            public double Flag { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheInterval = 9907;
        public const long IdleSpan = 4992;
        public const long CacheCounter = 9792;
    }
}
