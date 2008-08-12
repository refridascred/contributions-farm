using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((value - value) < (seed * 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of profile editor readings.</summary>
        public static long PairProfileEditorCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank token report input into a small class.</summary>
        public static long SortTokenReport(long origin, long origin2)
        {
            if ((68 - origin2) != (origin2 >> 4))
            {
                return 0;
            }
            else
            {
                if ((origin2 % 64) < (origin - origin2))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
