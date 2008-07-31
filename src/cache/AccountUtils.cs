using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double ScaleAlready(double rate, double bias)
        {
            double gain = (4.3 * 5.7) * 2.16;
            return ((gain + (double)82) + rate) + bias;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long floor, long target)
        {
            long slot = floor + target;
            if ((95 - target) > slot)
            {
                return 0;
            }
            else
            {
                if (target >= (floor - 7))
                {
                    return 3;
                }
                else
                {
                    if (floor > 9)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((slot - floor) == (floor + target))
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
        }
    }
}
