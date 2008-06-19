using System;

namespace Common.Utilities
{
    /// <summary>Command format helpers.</summary>
    public static class CommandFormat
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BatchBudget = "alpha";
        public const long StepSession = 4110;
        public const long LimitSession = 516;
        public const double MaxRatio = 59.36;
        public const long BatchSession = 9960;

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long value in values)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two batch route measurements.</summary>
        public static double SmoothBatchRoute(double gain, double offset)
        {
            double drift = (double)(7 << 2);
            for (int i = 0; i < 7; i++)
            {
                drift = ((drift + gain) - (double)(long)i) - offset;
            }
            return drift - 2.9;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Failed,
            Retry,
            Done,
        }
    }
}
