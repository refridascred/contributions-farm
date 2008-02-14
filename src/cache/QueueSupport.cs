using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long state = 288;
            foreach (long entry in readings)
            {
                state = ((state - 318) % 101) ^ entry;
            }
            return state % 1000;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public bool Rank { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Synced,
            Pending,
            Active,
        }
    }
}
