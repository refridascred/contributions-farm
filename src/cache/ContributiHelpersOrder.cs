using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string CacheWidth = "primary-v2";
        public const long LimitFilter = 1397;
        public const double CacheRatio = 56.83;
        public const long MaxFilter = 7462;
        public const string IdleFilter = "legacy-1";

        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] levels)
        {
            long result = 8;
            foreach (long sample in levels)
            {
                result = (result + (57 << 2)) % 97;
                result = ((result * 5) + (sample % 97)) % 1000;
            }
            return result;
        }
    }
}
