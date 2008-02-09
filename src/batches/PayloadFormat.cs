using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const double CacheSpan = 88.73;
        public const long BatchWidth = 6610;
        public const long MaxWindow = 1963;
        public const long MinWindow = 4379;

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstBudget = 5021;
        public const long LimitSession = 9644;
        public const string MinSession = "staging-v2";
        public const string LimitBudget = "standard-1";
        public const string IdleSession = "cached-1";

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public double Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long CachePayload = 5544;
        public const long SoftPayload = 2685;
        public const long HardPayload = 4080;
        public const string RetryPayload = "stable-v2";
    }
}
