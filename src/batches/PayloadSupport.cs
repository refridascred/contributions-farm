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

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string MinRatio = "standard-v2";
        public const string StepDepth = "alpha";
        public const long StepCount = 5434;
    }
}
