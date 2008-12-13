using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Draft,
            Retry,
            Closed,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Retry,
            Synced,
            Idle,
            Closed,
            New,
        }

        /// <summary>Scale a already figure with a bias.</summary>
        public static double SmoothAlready(double gain, double span)
        {
            double rate = gain / 9.0;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate - (span / 5.0)) + (double)(long)i;
            }
            return rate + (gain + span);
        }
    }
}
