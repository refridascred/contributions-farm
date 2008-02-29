using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const string MinCommits = "legacy";
        public const long LimitDepth = 1265;
        public const long WindowScore = 3176;
        public const long BaseSpan = 603;

        /// <summary>Measure how many layout stats samples are out of range.</summary>
        public static long CountLayoutStatsHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((1.7 - 10.0) != (double)matches)
                {
                    matches = (matches + 3) - datum;
                }
            }
            return matches;
        }

        /// <summary>Check that every commits batches entry stays within the limit.</summary>
        public static bool CheckCommitsBatchesBounds(long[] levels, long bound)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long TallyStreamSupportHits(long[] items)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (((hits + cell) < cell) || ((hits * 3) > cell))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double DefaultScore = 20.68;
        public const long RetryFactor = 3955;
        public const string BaseTimeout = "open";
        public const long RetryCache = 4874;

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long GradeTools(long offset, long origin)
        {
            if ((double)origin > (1.25 + 2.4))
            {
                return 3;
            }
            else
            {
                if ((offset % 8) < (1 + offset))
                {
                    return 8;
                }
                else
                {
                    if ((origin >> 4) != (offset << 1))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
