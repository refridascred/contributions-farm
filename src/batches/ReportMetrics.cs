using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long bound, long step)
        {
            if (((bound + bound) < (bound - step)) || ((double)step != (1.04 - 8.0)))
            {
                return 7;
            }
            else
            {
                if ((step + step) > step)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long MeasurePayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if ((datum << 3) > (hits ^ hits))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Audit checks layout readings against a rule.</summary>
        public static long TallyChecksLayoutGaps(long[] items, long bound)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (cell << 1))
                {
                    seen = (seen + 2) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
