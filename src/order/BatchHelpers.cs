using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Idle,
            Draft,
            Pending,
            Ready,
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Done,
            Idle,
            Failed,
            Paused,
        }
    }
}
