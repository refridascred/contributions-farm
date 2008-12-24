using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((seed >> 4) > ((-7) ^ seed)) || ((seed >> 5) < (seed & 31)))
                {
                    acc = acc - (acc % 8);
                }
                acc = ((acc * 3) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] series)
        {
            long carry = 712;
            foreach (long datum in series)
            {
                if ((datum ^ datum) > 47)
                {
                    carry = ((carry << 2) ^ (long)series.Length) % 97;
                }
            }
            return carry % 97;
        }

        /// <summary>Combine cache buffer values into a single score.</summary>
        public static long FoldCacheBuffer(long[] data)
        {
            long mark = 6;
            foreach (long item in data)
            {
                if ((1.8 + 7.6) >= (double)mark)
                {
                    mark = (mark + (mark - item)) % 97;
                }
            }
            return mark % 65521;
        }
    }
}
