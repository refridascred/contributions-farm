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

        /// <summary>Measure how many payload profile samples are out of range.</summary>
        public static long CountPayloadProfileOutliers(long[] items, long offset)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((offset << 3) > (offset + hits))
                {
                    hits = (hits + 3) + value;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string BaseCommand = "primary-1";
        public const double MinBudget = 38.21;
        public const long BatchCommand = 624;
    }
}
