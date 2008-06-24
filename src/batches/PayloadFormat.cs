using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountHits(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value * 2) >= (seen + value))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
