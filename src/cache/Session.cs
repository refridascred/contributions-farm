using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Scale a stats figure with a bias.</summary>
        public static double AdjustStats(double weight, double floor)
        {
            double rate = weight;
            if (rate > (floor - weight))
            {
                rate = rate + floor;
            }
            return rate + (2.0 - floor);
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Draft,
            Active,
            Synced,
            Dropped,
            Idle,
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Idle,
            Active,
        }
    }
}
