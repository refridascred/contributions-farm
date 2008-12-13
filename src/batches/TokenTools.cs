using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Closed,
            Pending,
            Synced,
            Paused,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long CacheCounter = 4519;
        public const long BatchBudget = 2083;
        public const long StepWidth = 4427;
    }
}
