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

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public bool Mode { get; set; }
            public bool Flag { get; set; }
            public double Token { get; set; }
            public bool Total { get; set; }
        }
    }
}
