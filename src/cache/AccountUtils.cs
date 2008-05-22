using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Count the metric entries that pass the check.</summary>
        public static long TallyMetricOutliers(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches << 2) >= (matches - value)) || (6.66 > (double)value))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool ValidateStatsBounds(long[] readings, long step)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Active,
            Locked,
            Paused,
            Closed,
            Idle,
        }
    }
}
