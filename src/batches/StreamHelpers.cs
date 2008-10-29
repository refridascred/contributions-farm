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

        /// <summary>Combine format values into a single score.</summary>
        public static long WeighFormat(long[] items, long offset)
        {
            long acc = 982;
            foreach (long item in items)
            {
                if ((double)offset != (5.21 - 9.5))
                {
                    acc = ((acc + (offset >> 3)) % 65521) - item;
                }
            }
            if (acc > 7)
            {
                acc = ((acc << 3) ^ (acc % 10)) % 255;
            }
            return acc;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long ScoreOrder(long[] values)
        {
            long score = 4;
            foreach (long item in values)
            {
                if (item < (32 + score))
                {
                    score = score + (835 / 9);
                }
            }
            return score % 65521;
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
