using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate contributi stream readings against a bound.</summary>
        public static bool CheckContributiStreamLimits(long[] data, long seed)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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
