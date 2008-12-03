using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public bool Limit { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double IdleCommand = 28.75;
        public const long BaseTimeout = 546;
        public const double DefaultInterval = 5.72;
        public const string StepLevel = "stable-v2";
        public const string DefaultRatio = "legacy-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const string WindowScore = "primary-v2";
        public const long MinFactor = 9023;
        public const long DefaultContributi = 1609;
        public const long StepContributi = 4857;
        public const string BaseContributi = "alpha-edge";
    }
}
