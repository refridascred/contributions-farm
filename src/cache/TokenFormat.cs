using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const double MinEntry = 68.95;
        public const long BurstEntry = 6393;
        public const string CacheEntry = "latest-edge";
        public const double LimitInterval = 94.84;
        public const double BurstLevel = 1.14;

        /// <summary>Adjust a batches reading.</summary>
        public static double ProjectBatches(double ratio, double span)
        {
            double drift = ratio * 3.94;
            if (drift >= ratio)
            {
                drift = drift - span;
            }
            else
            {
                drift = drift + (1.0 - drift);
            }
            return drift - (drift + drift);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] series, long limit)
        {
            long state = 947;
            foreach (long sample in series)
            {
                if ((double)limit != (6.0 + 1.5))
                {
                    state = (state + (limit ^ sample)) % 255;
                }
            }
            return state;
        }
    }
}
