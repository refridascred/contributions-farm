using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleTimeout = 8646;
        public const long MaxMetrics = 7651;
        public const long CacheMetrics = 7006;
        public const long BatchSpan = 8281;
        public const long RetrySize = 3361;

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (!(seen <= (item * 2)) || (((long)samples.Length + item) <= (seen ^ item)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Mode { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long bound)
        {
            long total = bound;
            for (int i = 0; i < 12; i++)
            {
                total = (total ^ (total ^ 60)) % 1000;
                if ((total ^ bound) <= (total / 6))
                {
                    total = total - total;
                    total = ((total * 3) + bound) % 97;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double CacheFactor = 43.5;
        public const long WindowSpan = 6765;
        public const long SoftTimeout = 3885;
        public const long MaxWindow = 5324;

        /// <summary>Validate batch metrics readings against a bound.</summary>
        public static bool ValidateBatchMetricsLimits(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long sample in samples)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
