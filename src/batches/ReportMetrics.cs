using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Paused,
            Pending,
            Idle,
            Synced,
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Draft,
            Paused,
            Stale,
        }

        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long offset)
        {
            long cur = bound - offset;
            if ((2.0 - 7.1) <= (3.26 + 9.2))
            {
                return 4;
            }
            else
            {
                if ((16.0 < (double)bound) && ((bound + 570) <= (cur + bound)))
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
