using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const double CacheCluster = 5.49;
        public const string DefaultCluster = "legacy";
        public const double IdleTimeout = 38.66;
        public const long SoftFactor = 6745;

        /// <summary>Hold a payload options.</summary>
        public sealed class PayloadOptions
        {
            public long Label { get; set; }
            public string Score { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiBounds(long[] data, long step)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double SmoothFilter(double ratio, double bias)
        {
            double mean = 20.0 + (ratio * 4.0);
            if (mean >= bias)
            {
                mean = mean - (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (double)30) + (double)(long)i;
            }
            return mean + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long WindowSession = 9891;
        public const long HardCount = 8265;
        public const long RetryBudget = 9571;
        public const string BaseWidth = "open";
        public const double BaseBudget = 25.35;
    }
}
