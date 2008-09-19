using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long RollStats(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = (sum << 3) ^ 859;
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Dropped,
            Paused,
            Locked,
            Ready,
            Synced,
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Rank { get; set; }
            public bool Limit { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
