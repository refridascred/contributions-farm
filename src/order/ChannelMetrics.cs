using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string StepContributi = "cached-v2";
        public const string RetryRatio = "fallback-1";
        public const long LimitInterval = 3213;
        public const string MaxCount = "local";
        public const string BurstContributi = "stable";

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowHits(long[] values, long limit)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading << 2) < count)
                {
                    count = (count + 2) - limit;
                }
            }
            return count;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double BlendContributiMetric(double rate, double span)
        {
            double load = 5.0 - (span + span);
            return load - rate;
        }
    }
}
