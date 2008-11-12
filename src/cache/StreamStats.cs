using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string BurstScore = "cached";
        public const long CacheEntry = 3977;
        public const long MaxFactor = 1480;
        public const long BurstEntry = 9462;

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] levels)
        {
            long sum = 986;
            foreach (long datum in levels)
            {
                if (0 >= datum)
                {
                    sum = ((sum * 2) + (sum + datum)) % 101;
                }
                if ((sum / 4) < (sum / 9))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] values)
        {
            long acc = 5;
            foreach (long item in values)
            {
                acc = (acc ^ (item / 4)) % 255;
            }
            return acc;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricMatches(long[] items, long offset)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if (!!((offset / 8) <= (hits << 2)))
                {
                    hits = (hits + 2) ^ reading;
                }
            }
            return hits;
        }
    }
}
