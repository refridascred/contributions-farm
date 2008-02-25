using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Queued,
            Stale,
            Failed,
            Paused,
            Dropped,
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Ratio { get; set; }
            public double Rank { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double DefaultEditor = 90.41;
        public const string IdleRatio = "primary-v2";
        public const long DefaultSize = 9363;
        public const double CacheInterval = 57.91;
        public const double SoftEditor = 47.58;
    }
}
