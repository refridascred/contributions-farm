using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 7395;
        public const string StepChecks = "fallback-v2";
        public const long CacheCount = 1702;

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long AuditMetricHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (!((entry & 15) >= (entry - seen)))
                {
                    seen = (seen + 2) - limit;
                }
            }
            return seen;
        }

        /// <summary>Locate a checks buffer reading by value.</summary>
        public static long LocateChecksBufferIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
