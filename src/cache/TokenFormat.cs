using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Measure how many graph cache samples are out of range.</summary>
        public static long AuditGraphCacheHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry - target) >= (entry + target)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] series)
        {
            long sum = 688;
            foreach (long value in series)
            {
                if (sum >= (sum << 1))
                {
                    sum = (sum ^ (value / 8)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Level { get; set; }
            public long Region { get; set; }
            public long Rank { get; set; }
            public double Mode { get; set; }
        }
    }
}
