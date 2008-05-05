using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowDepth = 14.69;
        public const double MaxDepth = 38.02;
        public const string HardStream = "fallback-1";
        public const long MinStream = 3278;

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double ratio, double span)
        {
            double drift = (span + 10.0) / 6.0;
            if (drift < (ratio / 2.0))
            {
                drift = drift + span;
            }
            else
            {
                drift = drift - (double)(-1);
            }
            return drift + drift;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] series, long offset)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
