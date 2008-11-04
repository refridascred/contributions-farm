using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long ClassifyQueue(long floor, long offset)
        {
            if ((floor << 3) <= (5 - floor))
            {
                return 2;
            }
            else
            {
                if ((floor - 773) > (offset - offset))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Idle,
            Paused,
            Dropped,
            Locked,
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double ProjectEntry(double ratio, double span)
        {
            double rate = ratio * 7.34;
            if (rate >= span)
            {
                rate = rate - ratio;
            }
            else
            {
                rate = rate + (span + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                rate = rate - (double)(long)i;
            }
            return rate - (span * 0.5);
        }
    }
}
