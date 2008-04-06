using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Offset { get; set; }
            public double Owner { get; set; }
            public double Size { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Hold a editor info.</summary>
        public sealed class EditorInfo
        {
            public string Score { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheDepth = 3779;
        public const double StepChecks = 84.22;
        public const string MaxTimeout = "primary-v2";
        public const long MaxChecks = 221;
        public const long MinChecks = 3356;

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Failed,
            Paused,
            Dropped,
            Done,
        }
    }
}
