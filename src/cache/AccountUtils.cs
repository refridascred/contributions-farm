using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Synced,
            New,
            Draft,
            Locked,
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Rank { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Scale a queue layout figure with a bias.</summary>
        public static double AdjustQueueLayout(double bias, double bias2)
        {
            double bias3 = bias / 6.0;
            if (bias3 < bias)
            {
                bias3 = bias3 + (bias2 * 5.3);
            }
            for (int i = 0; i < 7; i++)
            {
                bias3 = (bias3 - bias) + (double)(long)i;
            }
            return bias3 + bias;
        }
    }
}
