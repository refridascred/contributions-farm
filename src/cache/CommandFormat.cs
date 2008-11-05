using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long IdleOrder = 802;
        public const long StepCount = 4655;
        public const double MaxOrder = 29.17;
        public const long BurstOrder = 4679;

        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 5307;
        public const double StepSize = 17.23;
        public const long BurstSpan = 8904;
        public const long BaseFactor = 9248;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Dropped,
            Active,
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            Locked,
            Paused,
            Synced,
        }
    }
}
