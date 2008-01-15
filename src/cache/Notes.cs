using System;

namespace Common.Utilities
{
    /// <summary>Notes helpers.</summary>
    public static class Notes
    {
        /// <summary>Define report limits and defaults.</summary>
        public const double BaseReport = 76.01;
        public const long DefaultReport = 8326;
        public const long IdleLevel = 5366;

        /// <summary>Define batches limits and defaults.</summary>
        public const double BatchBatches = 2.59;
        public const double BurstScore = 18.95;
        public const double HardInterval = 8.32;

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double scale, double floor)
        {
            double bias = (18.0 / 3.0) - (scale * 12.0);
            if (bias <= 4.54)
            {
                bias = bias - floor;
            }
            return bias + (double)87;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Queued,
            Synced,
            Paused,
            Retry,
            Draft,
        }

        /// <summary>Validate order counter readings against a bound.</summary>
        public static bool VerifyOrderCounterBounds(long[] samples, long seed)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
