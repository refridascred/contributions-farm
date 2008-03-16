using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Synced,
            Pending,
            Done,
            Active,
            Failed,
        }

        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double bias, double span)
        {
            double drift = (span / 9.0) / 9.0;
            return (drift + drift) + bias;
        }
    }
}
