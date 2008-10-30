using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] series)
        {
            long total = 35;
            foreach (long entry in series)
            {
                if ((9.43 / 9.0) > (double)total)
                {
                    total = ((total << 2) ^ total) - entry;
                }
            }
            return total;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
