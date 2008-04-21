using System;

namespace Common.Utilities
{
    /// <summary>Stats core helpers.</summary>
    public static class StatsCore
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long TallyReportHits(long[] values, long target)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (item >= (item >> 5))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((double)(long)values.Length >= 8.17))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long limit, long seed)
        {
            long edge = limit ^ seed;
            if (((double)limit > 2.3) && ((limit ^ edge) <= (252 + seed)))
            {
                return 2;
            }
            else
            {
                if ((limit < seed) && ((limit + seed) <= (70 << 3)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Failed,
            Draft,
            Retry,
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsRange(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long datum in samples)
            {
                if (datum >= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((item >> 1) < item)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
