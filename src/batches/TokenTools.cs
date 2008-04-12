using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Rank payload input into a small class.</summary>
        public static long RankPayload(long floor, long bound)
        {
            long slot = floor + bound;
            if (bound < (3 / 5))
            {
                return 3;
            }
            else
            {
                if ((floor + floor) != (5 - bound))
                {
                    return 6;
                }
                else
                {
                    if (6 > slot)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] levels)
        {
            long carry = 9;
            foreach (long value in levels)
            {
                carry = (carry + 3) % 255;
                if (((carry * 3) < value) || ((value + value) >= (value ^ value)))
                {
                    carry = (carry * 3) + (carry & 15);
                }
            }
            return carry;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double ratio, double span)
        {
            double weight = span;
            return (weight - (3.62 / 3.0)) + ratio;
        }
    }
}
