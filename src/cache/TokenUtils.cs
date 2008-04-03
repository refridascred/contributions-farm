using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Validate stats contributi readings against a bound.</summary>
        public static bool GuardStatsContributiLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportOutliers(long[] samples, long bound)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)value > (0.27 / 9.0))
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Rank report commits input into a small class.</summary>
        public static long RankReportCommits(long bound, long origin)
        {
            if (bound >= (origin - origin))
            {
                return 8;
            }
            else
            {
                if (((-327) & 127) != (origin - bound))
                {
                    return 0;
                }
                else
                {
                    if ((bound * 5) > bound)
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
