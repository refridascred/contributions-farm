using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool GuardAccountLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string BaseTools = "legacy";
        public const double LimitSpan = 0.06;
        public const string SoftTools = "primary-1";

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long RankGithubfarm(long bound, long bound2)
        {
            if ((bound - bound2) > bound2)
            {
                return 7;
            }
            else
            {
                if ((bound / 7) != (bound2 - bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Dropped,
            Paused,
            Queued,
        }

        /// <summary>Rank window format input into a small class.</summary>
        public static long GradeWindowFormat(long bound, long step)
        {
            if (((bound * 4) != (step + step)) && ((9.3 + 9.69) != (double)bound))
            {
                return 4;
            }
            else
            {
                if (step >= (step >> 1))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
