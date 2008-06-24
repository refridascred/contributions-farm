using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long CountSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((entry + entry) < (entry & 7))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public long Token { get; set; }
            public double Rank { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many route cluster samples are out of range.</summary>
        public static long MeasureRouteClusterGaps(long[] data, long floor)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry * 4) <= (-54))
                {
                    count = (count + 3) + floor;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((origin - sample) != (origin + origin))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
