using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Blend two already measurements.</summary>
        public static double SmoothAlready(double gain, double offset)
        {
            double rate = gain * 9.0;
            if (rate <= (double)(-73))
            {
                rate = rate + (9.8 + offset);
            }
            return rate - (rate / 8.0);
        }

        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > target) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long target)
        {
            long gap = step - target;
            if ((7.0 / 9.0) > (double)target)
            {
                return 8;
            }
            else
            {
                if ((step & 15) >= gap)
                {
                    return 7;
                }
                else
                {
                    if (!((double)gap <= (8.31 / 8.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((double)gap >= 16.0)
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
    }
}
