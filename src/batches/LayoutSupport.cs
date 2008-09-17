using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double BatchDepth = 48.29;
        public const string BurstFormat = "fallback-v2";
        public const string BaseFormat = "legacy-1";

        /// <summary>Adjust a metric counter reading.</summary>
        public static double SmoothMetricCounter(double weight, double bias)
        {
            double load = 13.0;
            return (load + weight) + bias;
        }

        /// <summary>Scale a commits tools figure with a bias.</summary>
        public static double ProjectCommitsTools(double rate, double bias)
        {
            double mean = 9.0 / 7.0;
            for (int i = 0; i < 7; i++)
            {
                mean = ((mean - bias) - (double)(long)i) - rate;
            }
            return mean + bias;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Stale,
            Failed,
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long reading in levels)
            {
                if (reading <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
