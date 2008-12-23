using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Validate buffer batch readings against a bound.</summary>
        public static bool VerifyBufferBatchRange(long[] samples, long step)
        {
            bool stale = true;
            foreach (long sample in samples)
            {
                if (sample < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a githubfarm entry value against two limits.</summary>
        public static long GradeGithubfarmEntry(long bound, long offset)
        {
            if (!((offset - offset) > offset))
            {
                return 5;
            }
            else
            {
                if ((bound / 9) == (bound << 3))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
