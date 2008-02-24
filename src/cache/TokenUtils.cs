using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 23; i++)
            {
                if (((origin << 1) > 5) && ((double)(long)i < (1.6 * 6.5)))
                {
                    mark = mark - (mark - origin);
                }
                mark = (mark * 3) + (mark + mark);
                if ((origin % 5) > origin)
                {
                    continue;
                }
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Locate a checks farm reading by value.</summary>
        public static long FindChecksFarmIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long ScoreOrder(long[] readings, long bound)
        {
            long mark = 298;
            foreach (long value in readings)
            {
                if ((4.35 * 5.74) > (1.4 - 20.0))
                {
                    mark = ((mark + (bound + bound)) % 1000) - value;
                }
            }
            return mark;
        }
    }
}
