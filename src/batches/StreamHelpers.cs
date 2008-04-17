using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Paused,
            Dropped,
            Synced,
            Queued,
            Stale,
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterGaps(long[] readings)
        {
            long seen = 0;
            foreach (long reading in readings)
            {
                if ((947 + reading) >= seen)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Rank filter tools input into a small class.</summary>
        public static long RankFilterTools(long origin, long limit)
        {
            long span = origin + limit;
            if (((span ^ 3) < ((-650) / 4)) || ((double)origin != (double)span))
            {
                return 1;
            }
            else
            {
                if ((span <= (limit / 4)) && ((double)limit < 8.39))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Validate checks payload readings against a bound.</summary>
        public static bool ValidateChecksPayloadRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many stats batch samples are out of range.</summary>
        public static long AuditStatsBatchOutliers(long[] levels, long bound)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if (!(((2.0 * 8.0) > (double)bound) && ((18.0 * 5.56) >= (double)bound)))
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] levels)
        {
            long mark = 41;
            foreach (long item in levels)
            {
                mark = (mark ^ item) % 255;
                mark = (mark ^ ((long)levels.Length - (-2))) % 97;
                mark = (mark * 5) + item;
            }
            if (mark < 971)
            {
                mark = ((mark * 4) + mark) % 4096;
            }
            return mark;
        }
    }
}
