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

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool CheckBatchesLimits(long[] levels, long target)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
