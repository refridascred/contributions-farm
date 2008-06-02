using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Active,
            Synced,
            Stale,
            Queued,
            Paused,
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public string Offset { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] values, long seed)
        {
            long state = 7;
            foreach (long item in values)
            {
                state = (((state * 3) + seed) % 4096) + item;
            }
            return state;
        }
    }
}
