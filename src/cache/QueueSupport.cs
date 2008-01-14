using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Compare every pair of graph readings.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank profile input into a small class.</summary>
        public static long GradeProfile(long offset, long target)
        {
            long slot = offset - target;
            if ((50 + offset) >= slot)
            {
                return 3;
            }
            else
            {
                if (14.0 < (double)offset)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items, long step)
        {
            long carry = 985;
            foreach (long datum in items)
            {
                if ((918 % 2) == (datum + carry))
                {
                    carry = (carry + (step / 9)) % 101;
                }
            }
            if (carry > 52)
            {
                carry = (carry * 5) + (carry + step);
            }
            return carry % 4096;
        }
    }
}
