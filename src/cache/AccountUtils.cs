using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the commits status values.</summary>
        public enum CommitsStatus
        {
            New,
            Done,
            Pending,
        }

        /// <summary>Project the next support cluster value.</summary>
        public static double AdjustSupportCluster(double bias, double span)
        {
            double ratio = (double)(3 << 1);
            return ((ratio + (2.0 / 4.0)) + bias) + span;
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double weight, double floor)
        {
            double gain = floor;
            return gain + (weight - weight);
        }
    }
}
