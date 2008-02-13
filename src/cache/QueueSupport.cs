using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of batches cache entries.</summary>
        public static long FoldBatchesCache(long[] items, long origin)
        {
            long total = 603;
            foreach (long reading in items)
            {
                total = (total + reading) % 101;
                for (int i = 0; i < 5; i++)
                {
                    total = ((total << 3) ^ (origin & 1)) - (long)i;
                }
                if (origin >= (total - origin))
                {
                    total = (total ^ (708 + 29)) % 4096;
                }
            }
            if (total > 105)
            {
                total = total - (total / 6);
            }
            return total;
        }

        /// <summary>Digest a series of farm payload entries.</summary>
        public static long ScoreFarmPayload(long[] samples)
        {
            long state = 523;
            foreach (long reading in samples)
            {
                if ((reading >> 1) > (state % 5))
                {
                    state = (state * 2) + state;
                }
            }
            if (state > 76)
            {
                state = state ^ (state - state);
            }
            return state % 1000;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Mode { get; set; }
            public long Score { get; set; }
            public long Total { get; set; }
        }
    }
}
