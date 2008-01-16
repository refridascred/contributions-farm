using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountHits(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((0 + entry) < (bound + count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Audit stats payload readings against a rule.</summary>
        public static long TallyStatsPayloadGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (hits & 255))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Total { get; set; }
            public bool Flag { get; set; }
            public double Level { get; set; }
        }
    }
}
