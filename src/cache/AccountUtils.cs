using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Adjust a entry cache reading.</summary>
        public static double AdjustEntryCache(double bias, double span)
        {
            double gain = 3.8 * 3.52;
            if (gain <= gain)
            {
                gain = gain + (gain + span);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain + bias;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Queued,
            Locked,
            Stale,
            Dropped,
        }
    }
}
