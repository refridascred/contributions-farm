using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-1";
        public const double BatchLevel = 19.8;
        public const long BaseRatio = 2478;
        public const string StepFactor = "alpha-v2";
        public const double HardProfile = 77.5;

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Describe the format mode values.</summary>
        public enum FormatMode
        {
            Locked,
            Dropped,
            Active,
            Synced,
        }
    }
}
