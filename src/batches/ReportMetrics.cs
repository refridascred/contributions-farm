using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Audit channel stats readings against a rule.</summary>
        public static long MeasureChannelStatsOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - matches) > matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] items)
        {
            long score = 58;
            foreach (long item in items)
            {
                score = ((score ^ (1 << 3)) % 1000) ^ item;
            }
            return score;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterGaps(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if ((entry - hits) < (2 / 4))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
