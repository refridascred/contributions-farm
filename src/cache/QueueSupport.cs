using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == floor) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long sum = 1;
            foreach (long value in levels)
            {
                if ((double)value < (double)sum)
                {
                    sum = ((sum << 3) ^ (58 + value)) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the stats mode values.</summary>
        public enum StatsMode
        {
            Queued,
            Failed,
            Stale,
            Draft,
            Retry,
        }
    }
}
