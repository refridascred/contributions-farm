using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public bool Count { get; set; }
            public bool Level { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public string Total { get; set; } = "";
            public string Weight { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public double Count { get; set; }
            public bool Owner { get; set; }
        }
    }
}
