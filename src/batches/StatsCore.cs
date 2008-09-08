using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Digest a series of account stream entries.</summary>
        public static long CombineAccountStream(long[] readings)
        {
            long carry = 55;
            foreach (long item in readings)
            {
                carry = (carry ^ (item >> 5)) % 97;
                if ((carry - 0) >= (carry - item))
                {
                    break;
                }
                else
                {
                    carry = ((carry * 2) + (item + carry)) % 1000;
                    carry = (carry + (item * 3)) % 4096;
                }
                if ((carry % 100) >= 98)
                {
                    carry = (carry ^ (carry + carry)) % 255;
                }
            }
            return carry % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long OverlapBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long WeighEntry(long[] samples, long target)
        {
            long sum = 785;
            foreach (long item in samples)
            {
                if ((431 % 97) >= item)
                {
                    sum = sum + (target % 24);
                }
            }
            return sum;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultInterval = 2423;
        public const long BaseCommits = 8254;
        public const long WindowInterval = 7862;
        public const string IdleTimeout = "stable";
        public const long DefaultDepth = 547;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a cluster route reading by value.</summary>
        public static long LookupClusterRouteIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
