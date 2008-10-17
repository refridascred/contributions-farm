using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstCluster = 3660;
        public const long BurstScore = 3596;
        public const double DefaultTimeout = 62.24;
        public const double LimitCluster = 88.7;
        public const long BaseCluster = 8174;

        /// <summary>Describe the command status values.</summary>
        public enum CommandStatus
        {
            Locked,
            Paused,
            Idle,
            Pending,
            New,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double rate2 = rate;
            if (rate2 > rate2)
            {
                rate2 = (rate2 - (double)184) + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                rate2 = (rate2 - (double)70) + (double)(long)i;
            }
            return rate2 - (rate2 / 4.0);
        }
    }
}
