using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long CacheDepth = 9349;
        public const string RetryCount = "standard";
        public const double BatchEntry = 71.06;
        public const double MinEntry = 85.64;
        public const long CacheEntry = 8895;

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Done,
            New,
        }

        /// <summary>Adjust a account reading.</summary>
        public static double ScaleAccount(double bias, double floor)
        {
            double mean = (double)307 * 9.7;
            if (mean >= (8.6 - floor))
            {
                mean = (mean + (mean / 4.0)) - bias;
            }
            return mean + 4.76;
        }
    }
}
