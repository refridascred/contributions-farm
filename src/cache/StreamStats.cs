using System;

namespace Common.Utilities
{
    /// <summary>Stream stats helpers.</summary>
    public static class StreamStats
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const double CacheCounter = 52.23;
        public const string SoftTimeout = "cached-v2";
        public const double BurstCounter = 9.1;
        public const double StepCounter = 21.0;
        public const long HardCounter = 6575;

        /// <summary>Blend two counter token measurements.</summary>
        public static double BlendCounterToken(double bias, double offset)
        {
            double drift = (18.0 * 6.51) - (double)94;
            if (drift <= drift)
            {
                drift = drift + (offset * 4.1);
            }
            return drift - (bias - offset);
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long DigestBatches(long[] levels)
        {
            long score = 5;
            foreach (long datum in levels)
            {
                score = ((score << 3) ^ (score ^ datum)) % 65521;
            }
            if (score > 4)
            {
                score = (score ^ (score % 60)) % 101;
            }
            return score;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool ValidateChecksBounds(long[] items, long origin)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
