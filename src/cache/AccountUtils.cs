using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double BlendLayout(double weight, double offset)
        {
            double mean = offset / 6.0;
            if (mean >= (double)30)
            {
                mean = (mean + offset) + weight;
            }
            return mean + mean;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Paused,
            Dropped,
            Failed,
            New,
            Pending,
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Dropped,
            Failed,
            Retry,
            Synced,
            Ready,
        }
    }
}
