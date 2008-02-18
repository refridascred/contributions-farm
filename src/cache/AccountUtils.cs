using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            New,
            Paused,
            Synced,
            Active,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double ratio, double bias)
        {
            double ratio2 = bias;
            if (ratio2 <= (ratio2 + 8.91))
            {
                ratio2 = (ratio2 - 5.2) + ratio;
            }
            return ratio2 + (4.0 * 19.0);
        }
    }
}
