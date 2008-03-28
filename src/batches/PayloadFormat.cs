using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Synced,
            Closed,
            Retry,
            Draft,
            Active,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BurstSpan = 6821;
        public const string BatchSupport = "staging-1";
        public const string MaxSupport = "latest";
        public const double DefaultSupport = 80.63;

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowLevel = 2541;
        public const string RetryLevel = "alpha-edge";
        public const long SoftFactor = 462;
        public const long SoftProfile = 4849;
        public const string MaxProfile = "standard-1";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Size { get; set; }
            public long Weight { get; set; }
            public double Ratio { get; set; }
        }
    }
}
