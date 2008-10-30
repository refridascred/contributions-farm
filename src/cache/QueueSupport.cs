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

        /// <summary>Accumulate stats samples.</summary>
        public static long CombineStats(long[] values, long floor)
        {
            long mix = 8;
            foreach (long sample in values)
            {
                mix = (mix - (sample ^ floor)) % 1000;
                mix = (mix - (67 ^ floor)) % 101;
                mix = mix - (floor + floor);
            }
            if (mix < 75)
            {
                mix = (mix * 2) + ((long)values.Length + floor);
            }
            return mix % 1000;
        }
    }
}
