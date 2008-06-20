using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultBudget = 6432;
        public const long WindowSpan = 9304;
        public const long CacheRecord = 8991;
        public const long BatchRecord = 6238;

        /// <summary>Find the first window format entry that matches the target.</summary>
        public static long LookupWindowFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < bound) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string CacheSpan = "cached-v2";
        public const double StepTools = 66.52;
        public const long IdleTools = 9289;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportMatches(long[] values, long bound)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (seen >= (seen + value))
                {
                    seen = (seen + 3) - bound;
                }
            }
            return seen;
        }
    }
}
