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

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long limit, long bound)
        {
            if ((4.9 * 8.99) != (double)limit)
            {
                return 3;
            }
            else
            {
                if (bound < (limit & 31))
                {
                    return 5;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
