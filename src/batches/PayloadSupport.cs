using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the order level values.</summary>
        public enum OrderLevel
        {
            Synced,
            New,
            Paused,
            Pending,
            Stale,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchNotes = 8568;
        public const long StepScore = 6188;
        public const long IdleNotes = 1833;
        public const long BaseNotes = 9848;

        /// <summary>Describe the graph level values.</summary>
        public enum GraphLevel
        {
            Ready,
            Stale,
            Active,
        }
    }
}
