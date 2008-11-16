using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Iterate the checks series from a seed.</summary>
        public static long DeriveChecks(long step)
        {
            long carry = step;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double weight, double floor)
        {
            double rate = (7.9 + floor) - weight;
            if (rate > (weight - floor))
            {
                rate = rate + (double)6;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + (double)96) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long ClassifySession(long step, long seed)
        {
            long step2 = step - seed;
            if (seed <= (8 + 668))
            {
                return 8;
            }
            else
            {
                if ((step2 >= (3 % 2)) && ((step2 + step2) > (seed - seed)))
                {
                    return 5;
                }
                else
                {
                    if ((step < (step2 * 2)) && ((8.7 + 6.0) != (double)step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((seed + seed) <= (seed ^ step2))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
