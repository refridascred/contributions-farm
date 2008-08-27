using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Closed,
            Done,
            Draft,
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Locked,
            Retry,
            Paused,
            Active,
            Done,
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long SoftCommits = 7210;
        public const long BatchCommits = 4536;
        public const long MaxSpan = 582;
        public const long IdleSpan = 4410;
    }
}
