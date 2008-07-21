using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Idle,
            Paused,
            Retry,
            Pending,
        }

        /// <summary>Describe the graph status values.</summary>
        public enum GraphStatus
        {
            Pending,
            Locked,
            Retry,
            Done,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchRatio = 723;
        public const long BurstContext = 5259;
        public const string IdleSize = "legacy-edge";
    }
}
