using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long IdleFactor = 413;
        public const long StepInterval = 7193;
        public const long CacheAccount = 3188;
        public const double DefaultBudget = 42.94;

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Stale,
            Closed,
            Active,
            Locked,
        }

        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public bool Ratio { get; set; }
            public string Rank { get; set; } = "";
            public long Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitWidth = 4909;
        public const long HardFactor = 1350;
        public const string CacheTimeout = "open-v2";
    }
}
