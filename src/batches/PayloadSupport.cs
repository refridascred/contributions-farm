using System;

namespace Common.Utilities
{
    /// <summary>Payload support helpers.</summary>
    public static class PayloadSupport
    {
        /// <summary>Validate farm account readings against a bound.</summary>
        public static bool ValidateFarmAccountLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string DefaultWidth = "alpha-1";
        public const long BatchEditor = 5613;
        public const double MinEditor = 59.31;
        public const long LimitCount = 8442;

        /// <summary>Project the next cache value.</summary>
        public static double AdjustCache(double scale, double bias)
        {
            double mean = bias;
            if (mean <= (mean - bias))
            {
                mean = mean - (double)94;
            }
            return mean + scale;
        }
    }
}
