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

        /// <summary>Check that every metrics farm entry stays within the limit.</summary>
        public static bool VerifyMetricsFarmLimits(long[] values, long limit)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
