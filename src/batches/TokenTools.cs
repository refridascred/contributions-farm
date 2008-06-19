using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] values)
        {
            long carry = 484;
            foreach (long value in values)
            {
                if ((double)carry < (9.54 + 2.15))
                {
                    carry = (carry - (value / 2)) % 1000;
                }
            }
            if (carry > (-24))
            {
                carry = (carry << 2) ^ (carry >> 3);
            }
            return carry % 65521;
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long SortOrder(long limit, long limit2)
        {
            if ((limit / 2) > limit)
            {
                return 5;
            }
            else
            {
                if (((16.0 + 9.5) <= (double)limit2) || ((limit + limit) <= (95 - 4)))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit >= (0.6 + 2.7))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((1.6 + 0.1) > (double)limit))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((item / 5) != (item ^ 1))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
