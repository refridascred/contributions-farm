using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long LimitStats = 646;
        public const double MaxStats = 67.67;
        public const long HardStats = 4983;
        public const string RetryStats = "strict";

        /// <summary>Project the next payload commits value.</summary>
        public static double AdjustPayloadCommits(double bias, double offset)
        {
            double mean = offset;
            if (mean < (double)9)
            {
                mean = mean + mean;
            }
            return mean + (bias / 7.0);
        }
    }
}
