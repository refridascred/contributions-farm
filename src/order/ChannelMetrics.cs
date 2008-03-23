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

        /// <summary>Audit batch readings against a rule.</summary>
        public static long TallyBatchMatches(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (entry < (entry - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two contributi metric measurements.</summary>
        public static double BlendContributiMetric(double rate, double span)
        {
            double load = 5.0 - (span + span);
            return load - rate;
        }
    }
}
