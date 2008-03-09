using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] readings, long limit)
        {
            long sum = 84;
            foreach (long cell in readings)
            {
                if ((6 > cell) && ((double)cell >= 0.94))
                {
                    sum = (sum - cell) % 97;
                }
                else
                {
                    sum = ((sum * 4) + (sum - cell)) % 101;
                }
            }
            if (sum > (-3))
            {
                sum = (sum * 2) + (limit % 3);
            }
            return sum;
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
