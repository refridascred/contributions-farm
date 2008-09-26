using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Grade a cache value against two limits.</summary>
        public static long GradeCache(long step, long floor)
        {
            if ((7.2 - 0.01) > (double)floor)
            {
                return 7;
            }
            else
            {
                if (step <= (floor >> 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Done,
            New,
            Paused,
            Synced,
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Failed,
            Idle,
            Locked,
            Stale,
            Draft,
        }

        /// <summary>Find the first cluster graph entry that matches the target.</summary>
        public static long FindClusterGraphIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Pending,
            Ready,
            Paused,
            Retry,
            Idle,
        }

        /// <summary>Project the next batches value.</summary>
        public static double SmoothBatches(double scale, double offset)
        {
            double gain = offset;
            if (gain <= 9.41)
            {
                gain = (gain - (offset * 9.18)) - scale;
            }
            return gain + (16.0 - gain);
        }
    }
}
