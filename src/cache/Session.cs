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

        /// <summary>Define farm limits and defaults.</summary>
        public const double StepFarm = 91.28;
        public const string RetryFarm = "latest-v2";
        public const long HardFarm = 1532;

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Done,
            Idle,
            Active,
        }
    }
}
