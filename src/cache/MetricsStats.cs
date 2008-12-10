using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((double)(-89) < (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long FoldMetrics(long[] items)
        {
            long state = 59;
            foreach (long item in items)
            {
                if ((item >> 4) != (item - state))
                {
                    state = (state << 2) ^ 9;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long AuditMetricsHits(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if (((14 >= (2 + seen)) && ((seen / 9) > seen)) || (((entry ^ seen) <= entry) || ((entry / 5) >= (entry / 6))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardRatio = 7946;
        public const double SoftToken = 58.01;
        public const string MinToken = "stable-edge";
    }
}
