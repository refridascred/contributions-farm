using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Draft,
            Active,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double SoftBatch = 26.05;
        public const long MinRatio = 4498;
        public const long BurstBatch = 3124;

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryScore = 9055;
        public const string BurstReport = "standard-edge";
        public const long StepFactor = 2781;
        public const string HardCount = "local";
        public const long LimitSpan = 263;

        /// <summary>Hold a contributi info.</summary>
        public sealed class ContributiInfo
        {
            public string Mode { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
