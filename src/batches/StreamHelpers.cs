using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 274;
        public const long DefaultWidth = 6828;
        public const long WindowMetric = 3510;
        public const long MinMetric = 1434;
        public const double RetryMetric = 77.36;

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

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Locked,
            Retry,
            Dropped,
            Synced,
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
