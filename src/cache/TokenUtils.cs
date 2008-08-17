using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BatchFactor = 7894;
        public const long CacheSpan = 795;
        public const long IdleLevel = 6845;
        public const double MaxToken = 53.66;

        /// <summary>Scale a record figure with a bias.</summary>
        public static double AdjustRecord(double gain, double floor)
        {
            double gain2 = (double)80 + (18.0 - 7.5);
            if (gain2 >= (floor / 5.0))
            {
                gain2 = gain2 + (1.0 * 18.0);
            }
            return gain2 - gain;
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Idle,
            Retry,
            Failed,
            New,
        }
    }
}
