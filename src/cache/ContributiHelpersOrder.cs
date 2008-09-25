using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers order helpers.</summary>
    public static class ContributiHelpersOrder
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long LimitLevel = 5921;
        public const long BaseAccount = 3233;
        public const double StepBudget = 67.76;
        public const long CacheAccount = 8761;

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long floor, long limit)
        {
            if (7.0 >= (double)floor)
            {
                return 1;
            }
            else
            {
                if ((6.96 - 4.1) > (double)limit)
                {
                    return 2;
                }
                else
                {
                    if ((limit + floor) > (limit + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Scale a layout notes figure with a bias.</summary>
        public static double ScaleLayoutNotes(double gain, double offset)
        {
            double rate = (double)(7 + 357);
            if (rate >= (gain * 3.9))
            {
                rate = (rate + (rate + 6.18)) + offset;
            }
            else
            {
                rate = rate - (rate * 12.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - (rate - rate)) + (double)(long)i;
            }
            return rate + (double)5;
        }
    }
}
