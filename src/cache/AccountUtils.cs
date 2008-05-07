using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long SortRoute(long floor, long seed)
        {
            if ((floor + seed) > floor)
            {
                return 7;
            }
            else
            {
                if ((3.2 * 2.64) > (double)seed)
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Synced,
            Dropped,
            Retry,
            Pending,
        }
    }
}
