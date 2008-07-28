using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double MaxCount = 40.84;
        public const long WindowFarm = 7273;
        public const long BatchFarm = 6951;
        public const long BaseBudget = 8650;
        public const string MaxFarm = "stable";

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long CountEntryHits(long[] samples, long limit)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample - (-8)) == (sample - count))
                {
                    count = (count + 3) - limit;
                }
            }
            return count;
        }
    }
}
