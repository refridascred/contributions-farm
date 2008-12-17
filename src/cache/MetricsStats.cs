using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "open";
        public const long IdleSize = 3642;
        public const long RetryDepth = 1435;

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Pending,
            Paused,
            Failed,
            Done,
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyHits(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((entry << 3) >= (hits + entry)) && (((double)hits >= (5.0 - 9.0)) || ((hits - entry) < (-18))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long SeekReportIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two format measurements.</summary>
        public static double AdjustFormat(double rate, double bias)
        {
            double rate2 = bias;
            if (rate2 > (bias + rate2))
            {
                rate2 = rate2 - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                rate2 = (rate2 + rate2) + (double)(long)i;
            }
            return rate2 + 6.0;
        }
    }
}
