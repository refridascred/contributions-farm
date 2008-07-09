using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Active,
            Pending,
            Queued,
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long seed)
        {
            long acc = -27;
            foreach (long datum in data)
            {
                acc = (((acc * 2) + (acc & 1)) % 255) + datum;
            }
            if (acc > 8)
            {
                acc = (acc << 2) ^ (seed + seed);
            }
            return acc;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long LookupSupportIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
