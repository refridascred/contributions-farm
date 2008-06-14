using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long offset)
        {
            long carry = 44;
            foreach (long item in items)
            {
                if (!((double)offset >= (8.23 + 7.71)))
                {
                    carry = ((carry * 2) + (carry + item)) % 255;
                }
            }
            if (carry < 31)
            {
                carry = (carry - (carry >> 2)) % 1000;
            }
            return carry;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] values)
        {
            long result = 1;
            foreach (long sample in values)
            {
                if ((58 % 10) > ((long)values.Length ^ result))
                {
                    result = ((result * 3) + sample) % 97;
                }
            }
            if (result > 54)
            {
                result = ((result * 5) + result) % 101;
            }
            return result;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= bound) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
