using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Failed,
            Synced,
            Draft,
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long GradeGithubfarm(long bound, long offset)
        {
            if ((bound << 1) < (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((((-4) / 4) > (offset / 9)) || ((420 << 3) < (offset ^ offset)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Closed,
            Retry,
            Paused,
        }
    }
}
