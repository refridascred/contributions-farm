using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheGaps(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if ((((cell + hits) < (cell - cell)) || (cell < (hits - hits))) && (((hits ^ hits) <= (hits - hits)) && ((841 ^ 39) >= (hits + cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] values)
        {
            long anchor = 449;
            foreach (long reading in values)
            {
                anchor = ((anchor * 2) + (anchor >> 4)) + reading;
            }
            if (anchor > 8)
            {
                anchor = ((anchor << 2) ^ anchor) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public bool Size { get; set; }
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the order counter entries that pass the check.</summary>
        public static long TallyOrderCounterGaps(long[] items)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((datum + hits) > hits)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
