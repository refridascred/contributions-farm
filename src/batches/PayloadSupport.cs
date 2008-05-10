using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Hold a profile stats.</summary>
        public sealed class ProfileStats
        {
            public long Total { get; set; }
            public string Token { get; set; } = "";
            public bool Size { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheWindow = 89.67;
        public const double MinWindow = 74.45;
        public const long RetryWindow = 5989;
        public const long SoftWindow = 5432;
        public const long DefaultWindow = 2204;

        /// <summary>Hold a contributi summary.</summary>
        public sealed class ContributiSummary
        {
            public long Count { get; set; }
            public long Total { get; set; }
            public string Flag { get; set; } = "";
            public bool Region { get; set; }
        }
    }
}
