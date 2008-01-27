using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long limit, long seed)
        {
            if ((limit >> 5) <= limit)
            {
                return 2;
            }
            else
            {
                if (((2.78 + 6.96) > (double)limit) || ((7.0 - 2.6) == (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Validate commits readings against a bound.</summary>
        public static bool CheckCommitsLimits(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Validate counter context readings against a bound.</summary>
        public static bool VerifyCounterContextLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
