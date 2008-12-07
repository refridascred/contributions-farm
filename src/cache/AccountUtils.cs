using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Synced,
            Retry,
            Draft,
            New,
            Ready,
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Synced,
            Paused,
            Closed,
        }

        /// <summary>Blend two window measurements.</summary>
        public static double AdjustWindow(double gain, double floor)
        {
            double mean = (gain * 4.1) + (7.1 - gain);
            if (mean > floor)
            {
                mean = mean - (gain - floor);
            }
            else
            {
                mean = mean - (gain * 5.43);
            }
            return mean + (double)617;
        }
    }
}
