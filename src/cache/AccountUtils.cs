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

        /// <summary>Adjust a tools entry reading.</summary>
        public static double AdjustToolsEntry(double ratio, double floor)
        {
            double gain = floor;
            if (gain <= ratio)
            {
                gain = gain - (double)7;
            }
            return gain - (ratio / 2.0);
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
