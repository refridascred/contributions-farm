using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Draft,
            Stale,
        }

        /// <summary>Hold a command header.</summary>
        public sealed class CommandHeader
        {
            public double Total { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstRoute = 4366;
        public const long MaxRoute = 9329;
        public const long LimitRoute = 5103;
    }
}
