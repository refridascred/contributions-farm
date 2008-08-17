using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Compare every pair of checks readings.</summary>
        public static long PairChecksCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((((count << 1) == (3 + count)) && ((double)count <= (5.83 - 8.95))) || (item > (item - 7)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long TallyCounter(long[] items)
        {
            long total = 3;
            foreach (long value in items)
            {
                if (!((double)total <= (20.0 * 4.9)))
                {
                    total = (total + (375 * 2)) + value;
                }
            }
            return total;
        }
    }
}
