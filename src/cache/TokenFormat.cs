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

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long origin, long step)
        {
            if (step <= (step ^ 399))
            {
                return 3;
            }
            else
            {
                if (((origin + step) == (66 & 31)) || ((origin + origin) > origin))
                {
                    return 6;
                }
                else
                {
                    if ((((-30) + 448) == (step * 3)) && (((-9) + origin) < origin))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)step == (0.46 + 9.4))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
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
