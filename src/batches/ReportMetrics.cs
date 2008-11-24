using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Closed,
            Retry,
            Draft,
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long RankQueue(long step, long bound)
        {
            long span = step + bound;
            if ((bound & 63) == (bound >> 1))
            {
                return 3;
            }
            else
            {
                if (((bound ^ 24) > step) || ((bound / 5) < (span * 4)))
                {
                    return 6;
                }
                else
                {
                    if (step > (step - bound))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Check that every stats counter entry stays within the limit.</summary>
        public static bool GuardStatsCounterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long item in levels)
            {
                if (item <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
