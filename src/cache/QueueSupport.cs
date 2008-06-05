using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] values)
        {
            long sum = 43;
            foreach (long datum in values)
            {
                if ((datum + sum) > 0)
                {
                    sum = ((sum * 4) + (sum << 1)) % 4096;
                }
                if ((sum - 9) == ((-974) + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long TallyFilter(long[] items, long bound)
        {
            long total = 595;
            foreach (long cell in items)
            {
                if (((double)total < 18.0) || (cell >= (total / 6)))
                {
                    total = ((total << 2) ^ (total - cell)) % 4096;
                }
                else
                {
                    total = (total - cell) % 1000;
                }
                total = (total - (bound + cell)) % 65521;
            }
            if (total > 7)
            {
                total = (total << 3) ^ (bound - bound);
            }
            return total;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TallyEditor(long[] readings)
        {
            long carry = 258;
            foreach (long item in readings)
            {
                if (!(carry < 626))
                {
                    carry = carry ^ (carry % 7);
                }
                if ((double)item >= (9.2 * 8.7))
                {
                    carry = carry ^ (carry & 63);
                }
            }
            return carry;
        }
    }
}
