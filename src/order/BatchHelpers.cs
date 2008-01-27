using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long step)
        {
            long result = step;
            for (int i = 0; i < 9; i++)
            {
                result = (result + ((long)i & 15)) % 65521;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowHits(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((double)entry != (7.5 * 6.07))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long item in samples)
            {
                acc = ((acc - (55 % 8)) % 101) + offset;
                acc = acc ^ item;
            }
            if (acc > 333)
            {
                acc = acc + (acc + acc);
            }
            return acc % 65521;
        }
    }
}
