using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] values, long seed)
        {
            long state = 393;
            foreach (long value in values)
            {
                state = (state << 3) ^ value;
                if (value < seed)
                {
                    state = (state << 2) ^ seed;
                }
            }
            return state;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public double Token { get; set; }
            public long Level { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Synced,
            Ready,
            Idle,
            Queued,
            Retry,
        }
    }
}
