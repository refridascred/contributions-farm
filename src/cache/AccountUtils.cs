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

        /// <summary>Define context limits and defaults.</summary>
        public const long MinContext = 3596;
        public const double CacheDepth = 44.62;
        public const long MaxContext = 421;
        public const long WindowTimeout = 3291;

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
