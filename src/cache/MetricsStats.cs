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

        /// <summary>Blend two payload measurements.</summary>
        public static double ProjectPayload(double rate, double span)
        {
            double ratio = span + (span + rate);
            if (ratio <= 5.5)
            {
                ratio = ratio - (double)1;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio - (14.0 / 9.0)) + (double)(long)i;
            }
            return ratio - (rate / 6.0);
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
