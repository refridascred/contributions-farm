using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultSize = 9730;
        public const long DefaultRatio = 5863;
        public const string BatchAccount = "staging-edge";
        public const string MaxBudget = "latest-1";
        public const double RetryAccount = 63.03;

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Stamp { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Draft,
            Ready,
            Closed,
        }
    }
}
