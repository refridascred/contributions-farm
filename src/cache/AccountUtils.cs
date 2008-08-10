using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public double Mode { get; set; }
            public string Token { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BaseCount = 1634;
        public const long MaxEditor = 8568;
        public const long BurstEditor = 2092;
        public const double BurstSize = 54.78;

        /// <summary>Define context limits and defaults.</summary>
        public const long StepWidth = 8344;
        public const string LimitInterval = "stable-edge";
        public const string SoftContext = "stable-v2";
        public const long CacheSpan = 4985;
        public const long RetrySize = 2687;
    }
}
