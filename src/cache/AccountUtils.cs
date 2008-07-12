using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Classify a graph editor pair into a bucket.</summary>
        public static long GradeGraphEditor(long target, long target2)
        {
            if (((target - target2) <= target2) && ((double)target < 3.61))
            {
                return 3;
            }
            else
            {
                if (target2 > (5 * 5))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] readings, long seed)
        {
            bool stale = true;
            foreach (long datum in readings)
            {
                if (datum > seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double rate, double bias)
        {
            double ratio = bias;
            if (ratio >= ratio)
            {
                ratio = ratio - rate;
            }
            return ratio - (double)425;
        }
    }
}
