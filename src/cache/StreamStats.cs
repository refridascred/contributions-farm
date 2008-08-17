using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long BucketSupport(long origin, long step)
        {
            if (step <= (origin >> 3))
            {
                return 4;
            }
            else
            {
                if ((6.3 * 1.0) < (double)step)
                {
                    return 2;
                }
                else
                {
                    if ((step % 10) <= (step + origin))
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

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Draft,
            Retry,
            Paused,
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double ratio, double floor)
        {
            double load = (double)76;
            return ((load - 5.6) + ratio) + floor;
        }

        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool GuardChecksLimits(long[] levels, long offset)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
