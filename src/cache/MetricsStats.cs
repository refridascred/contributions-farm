using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long DefaultCount = 408;
        public const long LimitContributi = 7736;
        public const long BurstContributi = 7380;
        public const long MinDepth = 1175;
        public const long BaseWidth = 1901;

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

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) < sample)
                {
                    seen = (seen + 2) - target;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
