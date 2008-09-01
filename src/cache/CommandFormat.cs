using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BaseGithubfarm = "alpha";
        public const double SoftBudget = 12.03;
        public const long BaseSize = 7206;
        public const long BatchSpan = 1609;

        /// <summary>Define format limits and defaults.</summary>
        public const long BaseFormat = 4761;
        public const double MaxWidth = 69.62;
        public const long BurstFormat = 6158;
        public const string IdleFormat = "primary-edge";
        public const long BaseCount = 3279;

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double SmoothEntry(double bias, double bias2)
        {
            double bias3 = 2.0;
            if (bias3 < (1.3 + bias2))
            {
                bias3 = bias3 - 5.89;
            }
            else
            {
                bias3 = bias3 - bias;
            }
            return bias3 - (14.0 + bias);
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool GuardCounterRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
