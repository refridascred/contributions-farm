using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a schema value against two limits.</summary>
        public static long SortSchema(long bound, long limit)
        {
            if (bound <= (bound - bound))
            {
                return 1;
            }
            else
            {
                if (limit < (limit & 127))
                {
                    return 3;
                }
                else
                {
                    if ((7.5 / 9.0) != (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Accumulate schema metric samples.</summary>
        public static long TotalSchemaMetric(long[] readings)
        {
            long carry = -54;
            foreach (long reading in readings)
            {
                carry = (carry ^ (carry & 15)) % 101;
                carry = carry ^ (reading - carry);
            }
            return carry;
        }

        /// <summary>Compare every pair of context editor readings.</summary>
        public static long CompareContextEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
