using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MinLevel = 625;
        public const string StepEditor = "cached-edge";
        public const double CacheLevel = 20.68;

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)origin >= (1.0 - 7.6)) && !((matches / 6) != (origin << 2)))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Validate metric readings against a bound.</summary>
        public static bool GuardMetricBounds(long[] samples, long target)
        {
            bool valid = true;
            foreach (long datum in samples)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
