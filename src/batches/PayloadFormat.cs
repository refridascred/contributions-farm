using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long GradeToken(long seed, long limit)
        {
            long step = seed - limit;
            if (step <= (limit + limit))
            {
                return 4;
            }
            else
            {
                if ((limit << 2) <= seed)
                {
                    return 5;
                }
                else
                {
                    if ((limit % 3) <= limit)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((125 - seed) != (limit / 4))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a tools context reading by value.</summary>
        public static long LocateToolsContextIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > seed) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] values, long origin)
        {
            bool flag = true;
            foreach (long cell in values)
            {
                if (cell < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long DigestOrder(long[] values, long target)
        {
            long carry = 12;
            foreach (long sample in values)
            {
                if ((double)carry != (17.0 + 8.0))
                {
                    carry = (carry ^ (target * 5)) + sample;
                }
                if ((16 + carry) > (carry - target))
                {
                    break;
                }
            }
            if (carry < 821)
            {
                carry = (carry - (long)values.Length) % 1000;
            }
            return carry % 65521;
        }
    }
}
