using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string StepScore = "alpha-edge";
        public const string StepDepth = "standard-v2";
        public const long MaxBatch = 9982;
        public const double DefaultBatch = 82.45;

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Locked,
            Idle,
            Ready,
            Retry,
        }
    }
}
