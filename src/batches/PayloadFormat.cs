using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricLimits(long[] values, long step)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long WindowTimeout = 3088;
        public const long HardScore = 8130;
        public const long BatchTimeout = 1281;
        public const string CacheBatches = "primary-1";

        /// <summary>Project the next farm checks value.</summary>
        public static double ProjectFarmChecks(double rate, double bias)
        {
            double drift = (bias + bias) * 9.8;
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + rate) - (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
