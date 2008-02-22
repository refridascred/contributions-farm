using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long StepScore = 5562;
        public const long IdleCount = 1276;
        public const double CacheSpan = 9.95;
        public const string BurstLevel = "legacy-v2";

        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public string Mode { get; set; } = "";
            public long Count { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Paused,
            Active,
            Ready,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double IdleSize = 52.36;
        public const long StepCount = 3537;
        public const double BatchOrder = 37.97;
    }
}
