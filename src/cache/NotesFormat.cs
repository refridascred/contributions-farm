using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Level { get; set; }
            public string Limit { get; set; } = "";
            public long Ratio { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double WindowScore = 76.56;
        public const long CacheDepth = 4344;
        public const long RetryCommand = 1516;

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Idle,
            Locked,
            Closed,
            Failed,
        }
    }
}
