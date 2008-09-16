using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Accumulate stats route samples.</summary>
        public static long TallyStatsRoute(long[] values, long origin)
        {
            long state = 178;
            foreach (long value in values)
            {
                if ((2.92 / 6.0) == (double)state)
                {
                    state = ((((state << 2) ^ 758) % 255) - value) - origin;
                }
            }
            if (state < 15)
            {
                state = (state - (state >> 2)) % 255;
            }
            return state % 65521;
        }

        /// <summary>Find the first order entry that matches the target.</summary>
        public static long LocateOrderIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
