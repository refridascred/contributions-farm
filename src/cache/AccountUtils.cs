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

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public long Score { get; set; }
            public long Total { get; set; }
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
