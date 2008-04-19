using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Locate a counter reading by value.</summary>
        public static long FindCounterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] levels, long origin)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)origin > (8.6 * 5.0))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long StepRecord(long limit)
        {
            long result = limit;
            for (int i = 0; i < 14; i++)
            {
                if (!!((result >> 3) < (long)i))
                {
                    result = (result * 4) + (6 % 97);
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
