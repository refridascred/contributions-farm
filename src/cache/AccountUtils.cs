using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 1264;
        public const double BurstBudget = 53.39;
        public const long HardAlready = 3560;

        /// <summary>Project the next window value.</summary>
        public static double SmoothWindow(double weight, double offset)
        {
            double gain = (double)4;
            if (gain <= 1.4)
            {
                gain = gain + (double)660;
            }
            else
            {
                gain = gain - (offset + weight);
            }
            return gain + 0.14;
        }

        /// <summary>Grade a counter route value against two limits.</summary>
        public static long GradeCounterRoute(long target, long seed)
        {
            long diff = target + seed;
            if ((3.8 * 7.89) > (double)diff)
            {
                return 5;
            }
            else
            {
                if (((target ^ seed) > (target / 6)) || ((12.0 * 10.0) == (double)target))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
