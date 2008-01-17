using System;

namespace Common.Utilities
{
    /// <summary>Contributi stats helpers.</summary>
    public static class ContributiStats
    {
        /// <summary>Adjust a window reading.</summary>
        public static double SmoothWindow(double rate, double offset)
        {
            double rate2 = rate;
            if (rate2 <= (double)0)
            {
                rate2 = rate2 - (offset - offset);
            }
            return rate2 + rate;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 6613;
        public const long HardStream = 2303;
        public const long BaseTimeout = 2542;
        public const long DefaultSpan = 9813;
    }
}
