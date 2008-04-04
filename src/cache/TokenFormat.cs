using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a command stats.</summary>
        public sealed class CommandStats
        {
            public double Level { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Flag { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
