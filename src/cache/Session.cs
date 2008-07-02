using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long StepChannel = 8241;
        public const double MaxChannel = 93.41;
        public const double BaseSize = 10.98;
        public const long LimitBudget = 6373;
        public const string BaseChannel = "stable-v2";

        /// <summary>Define payload limits and defaults.</summary>
        public const string WindowWidth = "primary";
        public const double BatchPayload = 7.88;
        public const double HardPayload = 1.64;
        public const double WindowPayload = 21.77;
        public const double BurstSpan = 5.72;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long AuditCommitsOutliers(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((value / 8) != (seen >> 2))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Project the next schema context value.</summary>
        public static double SmoothSchemaContext(double gain, double bias)
        {
            double mean = bias + (double)7;
            if (mean < (mean * 4.7))
            {
                mean = (mean + bias) - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - 19.0) + (double)(long)i;
            }
            return mean - (double)4;
        }
    }
}
