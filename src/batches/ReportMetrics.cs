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

        /// <summary>Rank support input into a small class.</summary>
        public static long GradeSupport(long floor, long floor2)
        {
            if (floor > floor2)
            {
                return 0;
            }
            else
            {
                if ((floor >> 5) > floor)
                {
                    return 6;
                }
                else
                {
                    if ((double)floor2 > 6.0)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((floor + 329) == (floor2 / 6))
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
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
