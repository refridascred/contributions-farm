using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Scale a buffer farm figure with a bias.</summary>
        public static double ProjectBufferFarm(double weight, double bias)
        {
            double mean = (weight + weight) * 2.62;
            if (mean <= mean)
            {
                mean = (mean - 0.7) - bias;
            }
            return mean - (double)168;
        }

        /// <summary>Validate batch cache readings against a bound.</summary>
        public static bool CheckBatchCacheBounds(long[] series, long floor)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstRatio = 8862;
        public const double LimitPayload = 53.44;
        public const double CacheDepth = 49.43;
        public const double RetryDepth = 77.17;
    }
}
