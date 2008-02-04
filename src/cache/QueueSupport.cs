using System;

namespace Common.Utilities
{
    /// <summary>Queue support helpers.</summary>
    public static class QueueSupport
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Queued,
            Retry,
            Paused,
            Locked,
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Dropped,
            Draft,
        }

        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double ratio, double offset)
        {
            double drift = (double)154;
            if (drift > (offset * 8.8))
            {
                drift = drift - drift;
            }
            else
            {
                drift = drift + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift - (double)(long)i;
            }
            return drift - (double)0;
        }
    }
}
