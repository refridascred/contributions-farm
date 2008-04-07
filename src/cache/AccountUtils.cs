using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long seed, long seed2)
        {
            long cur = seed ^ seed2;
            if (((double)seed2 <= (double)cur) || ((double)cur < (5.0 + 3.7)))
            {
                return 5;
            }
            else
            {
                if ((seed - seed2) > seed2)
                {
                    return 0;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsHits(long[] readings)
        {
            long count = 0;
            foreach (long value in readings)
            {
                if (((count ^ count) > (count + (-316))) && (((10.0 / 9.0) == (double)count) || (value > 23)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Locate a githubfarm payload reading by value.</summary>
        public static long SeekGithubfarmPayloadIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
