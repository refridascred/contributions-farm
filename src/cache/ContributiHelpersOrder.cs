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

        /// <summary>Match up buffer entry samples.</summary>
        public static long OverlapBufferEntryCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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
