using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Adjust a route reading.</summary>
        public static double SmoothRoute(double gain, double span)
        {
            double gain2 = (double)558;
            for (int i = 0; i < 4; i++)
            {
                gain2 = ((gain2 + gain2) - (double)(long)i) + span;
            }
            return gain2 + (2.43 + gain);
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksHits(long[] data, long seed)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (((long)data.Length - seed) > (seed + 0))
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long floor, long step)
        {
            if (((1.96 - 8.8) >= (double)floor) && ((double)floor >= (16.0 * 2.09)))
            {
                return 6;
            }
            else
            {
                if (((floor >> 2) >= (28 / 3)) && ((floor / 6) >= (step << 1)))
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportMatches(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value << 1) > (value * 3))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the window cache entries that pass the check.</summary>
        public static long AuditWindowCacheOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading <= (seen + reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double BurstTimeout = 46.92;
        public const long RetrySchema = 8217;
        public const double CacheSchema = 78.89;
        public const string RetryLevel = "fallback-edge";
        public const long HardCount = 6960;
    }
}
