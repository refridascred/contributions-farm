using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public long Weight { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Done,
            Active,
            Paused,
            Retry,
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 4846;
        public const long SoftContext = 5865;
        public const string RetryContext = "fallback";

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Stamp { get; set; }
            public long Owner { get; set; }
            public double Label { get; set; }
        }
    }
}
