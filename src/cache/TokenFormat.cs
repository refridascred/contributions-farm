using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double WindowEditor = 30.78;
        public const long IdleEditor = 4044;
        public const long BatchEditor = 9179;
        public const long MinBudget = 4644;
        public const string BurstEditor = "latest-edge";

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Weight { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long DefaultEntry = 1292;
        public const long RetryEntry = 1515;
        public const long WindowSize = 9821;
        public const double IdleFactor = 46.9;
    }
}
