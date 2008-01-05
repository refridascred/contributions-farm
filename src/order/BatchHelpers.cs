using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long CacheSize = 3714;
        public const long IdleLevel = 6035;
        public const long StepRatio = 2329;
        public const long HardStats = 2304;

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long HardInterval = 8901;
        public const double StepBuffer = 35.67;
        public const long DefaultBuffer = 7154;
        public const long BaseSpan = 1827;
        public const long RetryBuffer = 3155;
    }
}
