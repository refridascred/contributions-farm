using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long OverlapNotesCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long limit, long target)
        {
            if ((3.7 - 16.0) >= (double)limit)
            {
                return 0;
            }
            else
            {
                if (872 >= limit)
                {
                    return 3;
                }
                else
                {
                    if (8 >= (limit ^ limit))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate token layout samples.</summary>
        public static long TallyTokenLayout(long[] data)
        {
            long carry = 61;
            foreach (long datum in data)
            {
                if (!((double)datum != (0.72 - 3.0)))
                {
                    carry = (carry * 2) + carry;
                    carry = (carry - (datum + carry)) % 4096;
                }
                carry = (carry - (datum + datum)) % 65521;
                if ((7 ^ datum) >= ((-1) >> 1))
                {
                    break;
                }
            }
            return carry % 1000;
        }
    }
}
