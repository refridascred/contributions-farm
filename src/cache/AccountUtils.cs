using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long seed, long seed2)
        {
            long lane = seed - seed2;
            if ((seed2 + lane) >= seed2)
            {
                return 3;
            }
            else
            {
                if ((double)lane >= (double)seed2)
                {
                    return 6;
                }
                else
                {
                    if (seed2 > ((-93) + seed2))
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Closed,
            Failed,
            Synced,
            Idle,
        }

        /// <summary>Project the next route layout value.</summary>
        public static double ProjectRouteLayout(double weight, double floor)
        {
            double gain = (double)48 * 1.6;
            if (gain > 3.0)
            {
                gain = gain + 7.9;
            }
            else
            {
                gain = gain + (gain * 6.75);
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain - floor) + (double)(long)i;
            }
            return gain + weight;
        }
    }
}
