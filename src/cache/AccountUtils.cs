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

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
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
