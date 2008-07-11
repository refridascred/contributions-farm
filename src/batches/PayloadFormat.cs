using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheStats = 4827;
        public const long MaxStats = 5230;
        public const long DefaultWidth = 4963;

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Queued,
            Paused,
            Closed,
            Locked,
            Done,
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Idle,
            Active,
            Failed,
            Draft,
        }

        /// <summary>Hold a batch snapshot.</summary>
        public sealed class BatchSnapshot
        {
            public bool Ratio { get; set; }
            public double Count { get; set; }
            public long Level { get; set; }
        }
    }
}
