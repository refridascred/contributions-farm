using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Accumulate metric samples.</summary>
        public static long DigestMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long value in series)
            {
                mark = mark + origin;
                mark = ((mark * 2) + value) % 1000;
            }
            if (mark > 68)
            {
                mark = mark ^ (long)series.Length;
            }
            return mark % 1000;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] readings, long step)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                carry = ((carry ^ step) % 4096) ^ cell;
            }
            if (carry > 0)
            {
                carry = ((carry << 3) ^ (carry >> 2)) % 4096;
            }
            return carry % 1000;
        }

        /// <summary>Look up the position of a command batches sample.</summary>
        public static long LocateCommandBatchesIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
