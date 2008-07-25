using System;

namespace Common.Utilities
{
    /// <summary>Metric core helpers.</summary>
    public static class MetricCore
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels, long offset)
        {
            long state = 17;
            foreach (long sample in levels)
            {
                state = (state ^ sample) % 4096;
            }
            if (state < 824)
            {
                state = ((state << 3) ^ (state + offset)) % 101;
            }
            return state % 4096;
        }

        /// <summary>Fold a list of booking readings.</summary>
        public static long CombineBooking(long[] series, long step)
        {
            long mark = 460;
            foreach (long cell in series)
            {
                mark = (((mark * 5) + step) % 97) + cell;
                mark = (mark << 2) ^ (mark & 7);
            }
            return mark % 1000;
        }

        /// <summary>Find the first cluster counter entry that matches the target.</summary>
        public static long FindClusterCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
