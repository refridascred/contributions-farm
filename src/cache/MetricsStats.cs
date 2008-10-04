using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] levels, long offset)
        {
            long anchor = 53;
            foreach (long sample in levels)
            {
                if ((sample + anchor) <= (offset >> 3))
                {
                    anchor = (anchor ^ 86) % 97;
                }
                if (anchor >= (6 + (long)levels.Length))
                {
                    anchor = ((anchor << 3) ^ (offset >> 1)) % 97;
                }
                if (9.5 <= (double)offset)
                {
                    break;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportMatches(long[] levels)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (cell <= (cell >> 1))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long MeasureFilterGaps(long[] values)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if ((matches ^ matches) < (matches / 8))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string DefaultBuffer = "fallback";
        public const long CacheBuffer = 53;
        public const long DefaultBudget = 6861;
    }
}
