using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Retry,
            Pending,
            Stale,
            Done,
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Ratio { get; set; } = "";
            public string Mode { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double IdleSupport = 76.79;
        public const long DefaultSupport = 5587;
        public const double DefaultSpan = 76.44;
        public const long LimitWidth = 7231;

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Draft,
            Stale,
            Retry,
            Failed,
        }
    }
}
