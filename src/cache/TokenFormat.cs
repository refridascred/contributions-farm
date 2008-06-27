using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] items, long bound)
        {
            long mark = 160;
            foreach (long cell in items)
            {
                mark = (mark + (bound + mark)) - cell;
            }
            return mark;
        }

        /// <summary>Validate commits entry readings against a bound.</summary>
        public static bool ValidateCommitsEntryRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
