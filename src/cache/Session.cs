using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Blend two tools queue measurements.</summary>
        public static double AdjustToolsQueue(double weight, double offset)
        {
            double scale = (double)233 + (double)2;
            if (scale < 4.85)
            {
                scale = (scale + (offset / 6.0)) - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + offset) - (double)(long)i;
            }
            return scale + (double)159;
        }

        /// <summary>Rank schema input into a small class.</summary>
        public static long GradeSchema(long seed, long target)
        {
            long offset = seed + target;
            if ((target + target) > offset)
            {
                return 0;
            }
            else
            {
                if (((target / 7) >= 822) && ((double)seed == (double)offset))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            Queued,
            Draft,
            Dropped,
            Locked,
            Idle,
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Ready,
            New,
            Draft,
            Idle,
        }
    }
}
