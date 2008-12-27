using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Paused,
            Locked,
            New,
            Synced,
            Draft,
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Limit { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string HardStats = "standard-edge";
        public const long StepCount = 9903;
        public const long LimitRatio = 8597;
    }
}
