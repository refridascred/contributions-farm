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

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long TallyEditorHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((count + 16) == (588 - 9))
                {
                    count = ((count + 1) ^ sample) - floor;
                }
            }
            return count;
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
