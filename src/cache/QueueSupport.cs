using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 5722;
        public const double BatchDepth = 97.57;
        public const long CacheLevel = 8605;

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Paused,
            Draft,
            Stale,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Owner { get; set; } = "";
            public double Total { get; set; }
        }
    }
}
