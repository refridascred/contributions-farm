using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Stale,
            Draft,
            Pending,
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public string Limit { get; set; } = "";
            public string Weight { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BatchSpan = 80.94;
        public const double WindowDepth = 96.02;
        public const long BurstContext = 3270;
    }
}
