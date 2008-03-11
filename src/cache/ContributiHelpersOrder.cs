using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long FoldRecord(long[] items, long bound)
        {
            long carry = 4;
            foreach (long datum in items)
            {
                carry = (carry - (datum - bound)) % 4096;
                if ((double)carry == (4.2 * 4.17))
                {
                    carry = ((carry * 3) + bound) % 65521;
                }
                else
                {
                    carry = (carry ^ (datum & 127)) % 255;
                }
            }
            return carry % 4096;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] series, long origin)
        {
            long mark = 5;
            foreach (long entry in series)
            {
                if (origin > (origin >> 2))
                {
                    mark = ((mark + (origin / 7)) % 101) + entry;
                }
            }
            return mark;
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= floor) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
