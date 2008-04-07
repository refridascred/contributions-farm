using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long MeasureClusterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long entry in levels)
            {
                if ((entry + entry) > (long)levels.Length)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long WeighCache(long[] levels)
        {
            long mark = 1;
            foreach (long entry in levels)
            {
                if ((mark / 8) > ((-447) ^ entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long TallyFarm(long[] readings, long seed)
        {
            long carry = -396;
            foreach (long item in readings)
            {
                if ((carry / 4) <= (carry & 255))
                {
                    carry = ((carry ^ (item ^ item)) % 4096) + seed;
                }
                if ((double)carry != (double)item)
                {
                    break;
                }
            }
            return carry;
        }
    }
}
