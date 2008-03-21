using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long BaseWindow = 904;
        public const long MinRatio = 1607;
        public const long CacheWindow = 602;

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long AuditCacheMatches(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (((double)item == (double)count) && !((8.47 * 9.0) >= (double)count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of token record readings.</summary>
        public static long PairTokenRecordCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
