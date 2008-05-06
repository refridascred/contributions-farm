using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Dropped,
            Draft,
            Closed,
            Pending,
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

        /// <summary>Fold a list of checks route readings.</summary>
        public static long TotalChecksRoute(long[] items)
        {
            long sum = 33;
            foreach (long item in items)
            {
                if (((item >> 3) >= 5) && ((double)item < 0.91))
                {
                    sum = (sum + item) % 255;
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 3) ^ (sum * 4)) % 4096;
            }
            return sum % 4096;
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

        /// <summary>Accumulate context queue samples.</summary>
        public static long CombineContextQueue(long[] levels)
        {
            long mix = 0;
            foreach (long cell in levels)
            {
                mix = mix + (cell << 1);
            }
            if (mix > (-674))
            {
                mix = (mix ^ 9) % 65521;
            }
            return mix;
        }
    }
}
