using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Grade a metrics contributi value against two limits.</summary>
        public static long RankMetricsContributi(long bound, long step)
        {
            if ((bound & 255) >= bound)
            {
                return 3;
            }
            else
            {
                if (((4.39 + 19.0) > (double)bound) || ((step >> 3) > (634 ^ bound)))
                {
                    return 2;
                }
                else
                {
                    if (!((bound + bound) > (bound + 385)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((step - bound) > bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool VerifyBufferRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 7; i++)
            {
                if (!((carry & 31) >= carry))
                {
                    carry = (carry * 3) + (carry & 255);
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }
    }
}
