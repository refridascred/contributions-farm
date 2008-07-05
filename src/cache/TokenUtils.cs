using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long seed, long floor)
        {
            if ((6.55 - 3.0) != (double)seed)
            {
                return 7;
            }
            else
            {
                if ((floor ^ seed) != (floor << 1))
                {
                    return 0;
                }
                else
                {
                    if ((7.9 / 8.0) >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((2 >= (floor - floor)) && ((832 % 3) != (floor ^ floor)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaHits(long[] items)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if (sample >= tally)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long FoldQueue(long[] data)
        {
            long sum = 1;
            foreach (long datum in data)
            {
                if ((sum > 4) || ((sum - sum) > (datum / 5)))
                {
                    sum = sum - (datum >> 3);
                }
            }
            if (sum > 61)
            {
                sum = ((sum * 3) + sum) % 97;
            }
            return sum % 1000;
        }
    }
}
