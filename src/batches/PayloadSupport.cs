using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Find the first cache entry that matches the target.</summary>
        public static long LookupCacheIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate stream order readings against a bound.</summary>
        public static bool ValidateStreamOrderLimits(long[] series, long seed)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long TallyQueueMatches(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((tally < 3) || ((717 % 3) == (16 - tally)))
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }
    }
}
