using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Weight { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Paused,
            Idle,
            Draft,
            Ready,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchTimeout = 3610;
        public const double MinTimeout = 50.22;
        public const double IdleProfile = 3.78;
        public const long HardProfile = 1806;
    }
}
