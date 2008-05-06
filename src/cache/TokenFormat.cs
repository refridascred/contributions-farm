using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Pending,
            New,
            Done,
            Active,
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Score { get; set; }
            public double Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Stamp { get; set; }
            public long Owner { get; set; }
        }
    }
}
