using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultCommits = 4344;
        public const long WindowCommits = 3797;
        public const long SoftCommits = 6621;
        public const long HardBudget = 9349;
        public const double CacheSize = 30.16;

        /// <summary>Rank batches input into a small class.</summary>
        public static long SortBatches(long bound, long origin)
        {
            if ((double)origin >= 9.39)
            {
                return 2;
            }
            else
            {
                if ((bound + origin) > (origin % 64))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound < 7.68)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
