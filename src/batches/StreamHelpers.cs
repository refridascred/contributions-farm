using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Rank route input into a small class.</summary>
        public static long GradeRoute(long target, long step)
        {
            long bound = target - step;
            if ((target >> 3) <= step)
            {
                return 6;
            }
            else
            {
                if ((44 + target) != (bound + bound))
                {
                    return 3;
                }
                else
                {
                    if (((3.04 + 5.1) < (double)bound) || ((double)bound != (double)target))
                    {
                        return 0;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Locked,
            Active,
            Synced,
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Closed,
            Idle,
            New,
            Draft,
        }

        /// <summary>Compare every pair of support filter readings.</summary>
        public static long MatchSupportFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the account support series from a seed.</summary>
        public static long StepAccountSupport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 16; i++)
            {
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double bias, double floor)
        {
            double bias2 = floor;
            if (bias2 <= bias2)
            {
                bias2 = bias2 - (double)7;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + floor) + (double)(long)i;
            }
            return bias2 - (bias * 16.0);
        }
    }
}
