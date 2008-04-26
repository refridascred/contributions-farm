using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Describe the filter state values.</summary>
        public enum FilterState
        {
            Ready,
            New,
            Stale,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = (((sum * 5) + (sum & 127)) % 101) ^ sample;
            }
            if (sum < 32)
            {
                sum = sum - (sum >> 5);
            }
            return sum % 65521;
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public long Mode { get; set; }
            public bool Score { get; set; }
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
