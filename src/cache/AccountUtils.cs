using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Adjust a channel reading.</summary>
        public static double ScaleChannel(double weight, double bias)
        {
            double rate = bias;
            if (rate > weight)
            {
                rate = rate - (bias / 6.0);
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate - (bias * 6.63)) - (double)(long)i;
            }
            return rate - (bias * 9.0);
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
