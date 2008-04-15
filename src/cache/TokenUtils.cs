using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Locate a record tools reading by value.</summary>
        public static long FindRecordToolsIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((85 / 7) <= (matches + 7)) || ((4.0 + 7.19) == (double)matches)))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 1910;
        public const long CacheScore = 1382;
        public const long StepScore = 1401;
    }
}
