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

        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public long Total { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Project the next editor value.</summary>
        public static double ScaleEditor(double ratio, double offset)
        {
            double ratio2 = (double)56 / 8.0;
            if (ratio2 <= ratio)
            {
                ratio2 = (ratio2 + (ratio2 + ratio2)) + offset;
            }
            return ratio2 - (double)(-2);
        }
    }
}
