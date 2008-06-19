using System;

namespace Common.Utilities
{
    /// <summary>Notes format helpers.</summary>
    public static class NotesFormat
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long RankMetric(long floor, long target)
        {
            if ((337 % 12) >= (405 - target))
            {
                return 6;
            }
            else
            {
                if ((8.1 * 7.87) > (double)floor)
                {
                    return 2;
                }
                else
                {
                    if ((26 ^ (-1)) > (floor / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many report stats samples are out of range.</summary>
        public static long CountReportStatsOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if ((limit + 3) < (seen - datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (((cell * 4) >= target) || (((1 / 2) <= (target ^ target)) && (112 < (cell - cell))))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
