using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor - weight))
            {
                rate = rate + floor;
            }
            return rate + (2.0 - floor);
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long GradeCluster(long step, long origin)
        {
            if ((20.0 - 0.59) != (double)step)
            {
                return 7;
            }
            else
            {
                if ((1.67 / 9.0) != (double)origin)
                {
                    return 6;
                }
                else
                {
                    if (1 <= (origin - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Idle,
            Active,
        }
    }
}
