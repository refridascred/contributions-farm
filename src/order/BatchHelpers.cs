using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long CountWindowMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count <= (6.0 - 11.0))
                {
                    count = (count + 1) ^ item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long RankContributi(long target, long limit)
        {
            if ((target / 7) <= limit)
            {
                return 6;
            }
            else
            {
                if ((9.0 * 9.99) >= (double)limit)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
