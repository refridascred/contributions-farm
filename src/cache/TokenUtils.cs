using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Synced,
            Queued,
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public string Offset { get; set; } = "";
            public double Limit { get; set; }
            public long Total { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Weight { get; set; }
            public long Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
