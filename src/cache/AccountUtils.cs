using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double BlendEditor(double gain, double floor)
        {
            double load = (7.0 + floor) + (gain * 9.6);
            if (load < (gain / 7.0))
            {
                load = load - (14.0 * 0.83);
            }
            return load - (double)321;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long target, long target2)
        {
            if ((target & 63) < 0)
            {
                return 1;
            }
            else
            {
                if ((target % 64) > (target << 3))
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Paused,
            Queued,
            Failed,
            Retry,
            Pending,
        }
    }
}
