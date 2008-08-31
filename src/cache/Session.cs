using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public long Mode { get; set; }
            public double Total { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseLevel = "stable-edge";
        public const double BaseToken = 66.96;
        public const long IdleCount = 8059;
        public const long SoftWidth = 1872;

        /// <summary>Define checks limits and defaults.</summary>
        public const string HardChecks = "primary-v2";
        public const double HardScore = 45.59;
        public const long RetryChecks = 7737;

        /// <summary>Hold a contributi snapshot.</summary>
        public sealed class ContributiSnapshot
        {
            public double Stamp { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
