using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long GradeChecks(long target, long target2)
        {
            long delta = target - target2;
            if ((double)target == (0.5 * 7.9))
            {
                return 7;
            }
            else
            {
                if (((target + delta) == (target ^ target2)) && (438 <= (target2 & 1)))
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Idle,
            Dropped,
            Failed,
        }

        /// <summary>Grade a githubfarm session value against two limits.</summary>
        public static long ClassifyGithubfarmSession(long target, long floor)
        {
            long lane = target + floor;
            if (!((1.3 / 5.0) <= (double)12))
            {
                return 5;
            }
            else
            {
                if (!((715 % 24) > lane))
                {
                    return 7;
                }
                else
                {
                    if (8.2 >= (double)lane)
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
}
