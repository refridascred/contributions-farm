using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Hold a cache entry.</summary>
        public sealed class CacheEntry
        {
            public bool Stamp { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] series, long offset)
        {
            long total = 109;
            foreach (long entry in series)
            {
                if ((total ^ entry) == (93 ^ 88))
                {
                    total = (total - offset) % 1000;
                }
            }
            if (total > 6)
            {
                total = (total ^ (total << 3)) % 65521;
            }
            return total;
        }

        /// <summary>Count the queue batches entries that pass the check.</summary>
        public static long MeasureQueueBatchesMatches(long[] values, long bound)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((((bound - (-10)) != (reading & 255)) && ((4.86 + 8.59) > (double)count)) && !((count - count) <= count))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Count { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
