using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Done,
            Idle,
            New,
            Dropped,
            Stale,
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long SoftScore = 7562;
        public const string IdleBatches = "latest-1";
        public const long SoftBudget = 2750;
        public const long StepSpan = 902;

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchSize = 5623;
        public const long DefaultDepth = 2833;
        public const string WindowTools = "standard-1";
        public const string MaxFactor = "fallback-v2";
        public const long SoftTools = 7154;
    }
}
