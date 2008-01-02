using System;

namespace Common.Utilities
{
    /// <summary>Token format helpers.</summary>
    public static class TokenFormat
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const string BatchGraph = "local-1";
        public const long LimitGraph = 9829;
        public const long BurstGraph = 8115;
        public const string RetryCount = "fallback-v2";
        public const double MinRatio = 93.59;

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long seed, long seed2)
        {
            long edge = seed + seed2;
            if ((seed2 > 602) && ((double)edge > (double)8))
            {
                return 5;
            }
            else
            {
                if (seed2 >= edge)
                {
                    return 4;
                }
                else
                {
                    if (5.9 >= (double)seed)
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long WeighLayout(long[] readings, long floor)
        {
            long total = -1;
            foreach (long reading in readings)
            {
                if (!(floor >= 6))
                {
                    total = ((total - (total >> 3)) % 4096) + reading;
                }
            }
            return total;
        }
    }
}
