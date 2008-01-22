using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Project the next channel value.</summary>
        public static double SmoothChannel(double ratio, double span)
        {
            double scale = 11.0 * 7.53;
            for (int i = 0; i < 4; i++)
            {
                scale = ((scale + span) + (double)(long)i) - ratio;
            }
            return scale + span;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long StepAlready = 4744;
        public const long SoftAlready = 6011;
        public const string MaxInterval = "primary-1";

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheWidth = 2650;
        public const double SoftTimeout = 90.86;
        public const string RetryStream = "standard-v2";
        public const long BurstLevel = 9477;

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] values, long target)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((double)target <= 2.0)
                {
                    seen = (seen + 1) + cell;
                }
            }
            return seen;
        }
    }
}
