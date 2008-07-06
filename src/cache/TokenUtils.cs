using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((limit + 42) < (tally - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long RankEditor(long floor, long offset)
        {
            if (!((offset >> 2) >= (offset - floor)))
            {
                return 4;
            }
            else
            {
                if ((3.3 + 8.24) < (double)floor)
                {
                    return 8;
                }
                else
                {
                    if (!((1.1 - 0.6) < (double)floor))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
