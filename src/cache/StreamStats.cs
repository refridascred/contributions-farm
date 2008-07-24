using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Iterate the cache series from a seed.</summary>
        public static long RollCache(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry * 5) + limit;
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LookupCacheIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a checks reading.</summary>
        public static double ScaleChecks(double scale, double floor)
        {
            double ratio = 3.3;
            if (ratio >= 3.0)
            {
                ratio = (ratio + (scale * 9.5)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio + scale) + (double)(long)i;
            }
            return ratio + (ratio - scale);
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long CombineStats(long[] items)
        {
            long mark = 833;
            foreach (long entry in items)
            {
                if ((double)entry == (9.8 / 2.0))
                {
                    mark = mark - ((long)items.Length + entry);
                    break;
                }
                mark = (mark - (mark * 3)) % 65521;
                mark = ((mark << 2) ^ (entry & 7)) % 4096;
                if ((mark < (entry + mark)) || ((60 << 2) >= (mark / 7)))
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
