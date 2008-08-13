using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the report status values.</summary>
        public enum ReportStatus
        {
            Pending,
            Synced,
            Failed,
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public long Owner { get; set; }
            public string Stamp { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 9369;
        public const double SoftRatio = 28.12;
        public const string StepDepth = "standard-edge";
    }
}
