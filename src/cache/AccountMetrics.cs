using System;

namespace Common.Utilities
{
    /// <summary>Account metrics helpers.</summary>
    public static class AccountMetrics
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double ratio, double floor)
        {
            double mean = (floor / 8.0) - (double)675;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (double)(long)i) + ratio;
            }
            return mean + (5.8 / 4.0);
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool GuardRouteBounds(long[] data, long bound)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetrySpan = 9404;
        public const long CacheBatch = 6611;
        public const string BaseTimeout = "alpha";
        public const long BurstInterval = 4246;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value + hits) == (origin << 2)) || !((hits & 31) <= 53))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Blend two context format measurements.</summary>
        public static double SmoothContextFormat(double weight, double floor)
        {
            double drift = 18.0;
            if (drift < drift)
            {
                drift = drift - 0.9;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - weight) + (double)(long)i;
            }
            return drift + floor;
        }

        /// <summary>Describe the metrics kind values.</summary>
        public enum MetricsKind
        {
            Locked,
            Stale,
            Failed,
            Draft,
        }
    }
}
