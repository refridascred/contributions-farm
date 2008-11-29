using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Digest a series of queue entries.</summary>
        public static long FoldQueue(long[] series, long bound)
        {
            long sum = 326;
            foreach (long item in series)
            {
                if (!((6.4 / 5.0) >= (double)sum))
                {
                    sum = (sum ^ (bound % 2)) % 1000;
                }
                else
                {
                    sum = sum - sum;
                }
                if (((33 % 8) != (bound + item)) || ((33 + sum) < (item + bound)))
                {
                    sum = ((sum << 2) ^ sum) % 101;
                }
                else
                {
                    sum = sum ^ sum;
                }
            }
            return sum;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] data)
        {
            long total = 76;
            foreach (long item in data)
            {
                if ((item << 2) != (item - item))
                {
                    total = total - (item - item);
                }
            }
            if (total > 3)
            {
                total = (total ^ (33 + total)) % 1000;
            }
            return total % 4096;
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long step)
        {
            long carry = step;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
