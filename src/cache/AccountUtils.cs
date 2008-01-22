using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsGaps(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((item - (long)values.Length) >= (item & 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry checks series from a seed.</summary>
        public static long RollEntryChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 3) ^ (total + origin)) % 255;
                if (((long)i + total) >= total)
                {
                    total = (total << 3) ^ origin;
                }
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }
    }
}
