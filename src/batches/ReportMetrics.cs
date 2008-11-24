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

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long origin, long offset)
        {
            long step = origin ^ offset;
            if ((2.2 / 8.0) == (double)step)
            {
                return 7;
            }
            else
            {
                if ((origin - origin) <= (step >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((651 - step) > (offset >> 4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
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
