using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long TallyBatches(long[] data)
        {
            long sum = -240;
            foreach (long datum in data)
            {
                sum = (((sum * 3) + (7 << 3)) % 4096) - datum;
            }
            if (sum < (-124))
            {
                sum = (sum ^ (sum << 3)) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Active,
            Locked,
            Synced,
            Pending,
            Dropped,
        }
    }
}
