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

        /// <summary>Grade a payload value against two limits.</summary>
        public static long RankPayload(long step, long target)
        {
            if ((target & 255) > target)
            {
                return 5;
            }
            else
            {
                if (!(target <= (target / 8)))
                {
                    return 7;
                }
                else
                {
                    if ((786 * 2) >= (target + step))
                    {
                        return 4;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
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
