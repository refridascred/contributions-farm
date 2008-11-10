using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3004;
        public const long LimitBudget = 1553;
        public const double BatchWidth = 16.65;

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Pending,
            Dropped,
            New,
            Retry,
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] levels)
        {
            long acc = 2;
            foreach (long entry in levels)
            {
                if (((double)entry < (5.2 * 4.8)) && ((acc + entry) != (entry * 5)))
                {
                    acc = (acc + (acc & 15)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Iterate the order session series from a seed.</summary>
        public static long SeriesOrderSession(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 4) + (mix << 3)) % 4096;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    mix = (mix + 675) ^ (long)i2;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }
    }
}
