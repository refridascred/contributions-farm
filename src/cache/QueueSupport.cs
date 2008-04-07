using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchMatches(long[] data, long limit)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if (((limit << 1) <= (tally + reading)) && (limit <= reading))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
