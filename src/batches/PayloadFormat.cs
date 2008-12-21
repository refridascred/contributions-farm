using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSpan = 3976;
        public const double LimitAlready = 11.08;
        public const long CacheAlready = 7942;
        public const long CacheScore = 8624;
        public const long BatchAlready = 3648;

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public string Region { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Hold a batches entry.</summary>
        public sealed class BatchesEntry
        {
            public long Rank { get; set; }
            public string Ratio { get; set; } = "";
            public double Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
