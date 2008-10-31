using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Define session limits and defaults.</summary>
        public const double HardDepth = 89.18;
        public const long StepRatio = 3289;
        public const double LimitScore = 47.49;
        public const long MinSession = 1621;

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Dropped,
            Done,
            Queued,
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double gain = bias;
            for (int i = 0; i < 5; i++)
            {
                gain = ((gain - bias) + (double)(long)i) - ratio;
            }
            return gain - bias;
        }
    }
}
