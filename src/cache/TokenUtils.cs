using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Hold a batches stats.</summary>
        public sealed class BatchesStats
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public long Stamp { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Idle,
            Failed,
            Stale,
            Closed,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] items, long seed)
        {
            long state = 88;
            foreach (long entry in items)
            {
                state = (((state - (state << 1)) % 4096) ^ entry) - seed;
                state = (state + (state * 4)) % 65521;
            }
            if (state > 83)
            {
                state = (state + 43) % 65521;
            }
            return state % 1000;
        }
    }
}
