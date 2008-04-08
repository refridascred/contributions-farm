using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Check that every command channel entry stays within the limit.</summary>
        public static bool VerifyCommandChannelLimits(long[] values, long bound)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the cluster checks entries that pass the check.</summary>
        public static long AuditClusterChecksOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if ((double)reading == (2.0 * 7.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (((seen + 46) < item) || ((item + item) < 18))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
