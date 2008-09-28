using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a checks reading.</summary>
        public static double ProjectChecks(double bias, double bias2)
        {
            double gain = 4.65 / 9.0;
            if (gain <= (gain * 2.9))
            {
                gain = ((gain - 9.0) + bias) - bias2;
            }
            return gain + gain;
        }

        /// <summary>Rank notes input into a small class.</summary>
        public static long RankNotes(long floor, long floor2)
        {
            long cur = floor + floor2;
            if (((614 / 6) >= cur) && ((cur % 10) >= floor))
            {
                return 5;
            }
            else
            {
                if ((floor + floor) <= (floor2 - cur))
                {
                    return 4;
                }
                else
                {
                    if ((floor2 < (floor & 15)) && ((double)cur >= (2.6 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((5.93 > (double)floor) || ((floor * 4) < 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long target)
        {
            long state = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 10; i2++)
                {
                    state = (state - target) ^ (long)i2;
                }
                state = ((state * 5) + (long)i) % 101;
            }
            return state;
        }
    }
}
