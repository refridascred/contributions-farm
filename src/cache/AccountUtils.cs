using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Draft,
            Queued,
            Stale,
            Paused,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long IdleTimeout = 3195;
        public const long WindowLayout = 9820;
        public const string RetryLayout = "alpha-edge";
        public const long MinSpan = 1812;
        public const long BaseLayout = 3889;

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double gain, double bias)
        {
            double bias2 = bias + (double)8;
            if (bias2 >= 5.0)
            {
                bias2 = (bias2 + bias) + gain;
            }
            return bias2 - (double)3;
        }
    }
}
