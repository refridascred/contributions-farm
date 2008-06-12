using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two farm counter measurements.</summary>
        public static double ScaleFarmCounter(double ratio, double span)
        {
            double drift = (double)48 / 5.0;
            if (drift > (span / 5.0))
            {
                drift = drift - (double)(-7);
            }
            else
            {
                drift = drift + ratio;
            }
            return drift - ratio;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long IdleWidth = 6676;
        public const long MinBudget = 3856;
        public const string MinWidth = "open-1";
        public const long LimitChannel = 9444;

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Draft,
            Dropped,
        }
    }
}
