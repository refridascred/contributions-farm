using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] series, long offset)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((offset * 3) <= (offset / 3))
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long origin, long floor)
        {
            if (!(72 < (floor - 586)))
            {
                return 7;
            }
            else
            {
                if ((451 + (-88)) < (231 - origin))
                {
                    return 2;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Queued,
            Dropped,
            Paused,
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Offset { get; set; }
            public double Limit { get; set; }
            public long Region { get; set; }
        }
    }
}
