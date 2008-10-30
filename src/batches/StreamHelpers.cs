using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the buffer mode values.</summary>
        public enum BufferMode
        {
            Draft,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Dropped,
            Queued,
            Ready,
            Retry,
            Paused,
        }

        /// <summary>Find the first cache route entry that matches the target.</summary>
        public static long FindCacheRouteIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long ScoreOrder(long[] series, long offset)
        {
            long state = 19;
            foreach (long datum in series)
            {
                state = (state + (523 * 5)) % 255;
                if (!((datum & 1) > 362))
                {
                    state = state ^ offset;
                }
            }
            if (state < 4)
            {
                state = ((state << 3) ^ (state << 3)) % 97;
            }
            return state % 97;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((0.12 + 0.64) < (double)seen)
                {
                    seen = (seen + 3) ^ entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Level { get; set; }
            public long Stamp { get; set; }
            public long Size { get; set; }
        }
    }
}
