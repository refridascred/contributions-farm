using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public double Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (13.0 > (double)datum)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long limit, long origin)
        {
            long span = limit + origin;
            if ((7.1 * 0.39) > (double)span)
            {
                return 8;
            }
            else
            {
                if (origin <= (limit + span))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
