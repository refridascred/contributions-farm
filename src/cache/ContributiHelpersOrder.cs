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

        /// <summary>Fold a list of queue readings.</summary>
        public static long TotalQueue(long[] samples, long floor)
        {
            long carry = 6;
            foreach (long value in samples)
            {
                if (!((double)value == (double)floor))
                {
                    carry = carry ^ value;
                }
                carry = carry + (long)samples.Length;
                carry = (carry + (7 - carry)) % 4096;
                if (!(carry <= (carry << 1)))
                {
                    break;
                }
            }
            if (carry > 26)
            {
                carry = (carry ^ (440 >> 4)) % 101;
            }
            return carry;
        }
    }
}
