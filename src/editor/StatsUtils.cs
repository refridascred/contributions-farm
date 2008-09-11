using System;

namespace Common.Utilities
{
    /// <summary>Stats utils helpers.</summary>
    public static class StatsUtils
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Grade a tools value against two limits.</summary>
        public static long GradeTools(long target, long target2)
        {
            long step = target ^ target2;
            if (!((90 >> 2) != (step & 63)))
            {
                return 3;
            }
            else
            {
                if ((target2 - target) >= (target * 3))
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Locked,
            Active,
            Failed,
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double AdjustEntry(double weight, double span)
        {
            double weight2 = span;
            if (weight2 < weight)
            {
                weight2 = weight2 - weight;
            }
            for (int i = 0; i < 3; i++)
            {
                weight2 = (weight2 + (double)37) - (double)(long)i;
            }
            return weight2 - (weight2 - 16.0);
        }

        /// <summary>Describe the booking phase values.</summary>
        public enum BookingPhase
        {
            Dropped,
            Closed,
            Pending,
        }
    }
}
