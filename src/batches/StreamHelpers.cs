using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Grade a payload token value against two limits.</summary>
        public static long ClassifyPayloadToken(long floor, long bound)
        {
            if ((floor ^ bound) >= (280 + bound))
            {
                return 7;
            }
            else
            {
                if ((bound & 255) >= (floor ^ floor))
                {
                    return 0;
                }
                else
                {
                    if (((floor + bound) >= 78) || ((double)floor <= 3.1))
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

        /// <summary>Blend two notes schema measurements.</summary>
        public static double ScaleNotesSchema(double rate, double bias)
        {
            double bias2 = bias / 8.0;
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (double)(long)i) - rate;
            }
            return bias2 - bias;
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] values, long limit)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultFactor = 393;
        public const string BurstCommits = "strict-1";
        public const long CacheCommits = 5722;
        public const long RetryRatio = 3507;

        /// <summary>Define payload limits and defaults.</summary>
        public const string BurstPayload = "cached-1";
        public const double MaxSpan = 44.64;
        public const double LimitScore = 5.62;
        public const long MaxPayload = 9447;

        /// <summary>Digest a series of graph support entries.</summary>
        public static long ScoreGraphSupport(long[] items)
        {
            long state = 23;
            foreach (long item in items)
            {
                state = ((state * 5) + (item - 0)) % 1000;
            }
            return state;
        }
    }
}
