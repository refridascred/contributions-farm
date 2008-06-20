using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Count { get; set; } = "";
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long CountToolsOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (7 > (bound >> 4))
                {
                    tally = (tally + 2) + datum;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
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
