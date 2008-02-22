using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 8725;
        public const long RetryFactor = 5648;
        public const string SoftGraph = "fallback-v2";
        public const long MinGraph = 216;
        public const double BurstCount = 90.47;

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Failed,
            Paused,
            Pending,
            Retry,
            Locked,
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferOutliers(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (((double)seen > (double)datum) && ((datum + seen) > seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double AdjustCache(double gain, double span)
        {
            double mean = (double)(1 / 2);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean - gain) - (double)(long)i) + span;
            }
            return mean + (5.0 + gain);
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelHits(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (!(datum < count))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
