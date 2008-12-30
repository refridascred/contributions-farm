using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Measure how many filter contributi samples are out of range.</summary>
        public static long TallyFilterContributiHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((entry * 3) > (tally >> 3))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long TotalCache(long[] data)
        {
            long carry = -565;
            foreach (long item in data)
            {
                carry = carry ^ item;
                if ((carry >> 4) >= (carry ^ item))
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
