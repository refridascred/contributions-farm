using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public bool Token { get; set; }
            public long Size { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Pending,
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public double Flag { get; set; }
            public double Region { get; set; }
            public double Score { get; set; }
        }
    }
}
