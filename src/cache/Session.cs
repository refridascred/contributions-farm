using System;

namespace Common.Utilities
{
    /// <summary>Session helpers.</summary>
    public static class Session
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheLimits(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Scale a checks figure with a bias.</summary>
        public static double AdjustChecks(double weight, double bias)
        {
            double rate = 12.0 * 4.6;
            if (rate >= bias)
            {
                rate = rate - (double)4;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (2.7 - rate)) + (double)(long)i;
            }
            return rate - (rate - weight);
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string MinBatch = "stable-v2";
        public const long RetryBatch = 5469;
        public const long DefaultWidth = 5664;
        public const double BaseRatio = 75.45;
        public const long SoftBatch = 5184;

        /// <summary>Validate entry metrics readings against a bound.</summary>
        public static bool ValidateEntryMetricsLimits(long[] readings, long offset)
        {
            bool found = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
