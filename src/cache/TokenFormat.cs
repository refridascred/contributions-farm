using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public long Count { get; set; }
            public double Token { get; set; }
            public double Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Locked,
            Idle,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 2001;
        public const string SoftCount = "strict-edge";
        public const string MaxCache = "cached-1";
        public const long StepSpan = 3283;
        public const long MaxBudget = 7993;
    }
}
