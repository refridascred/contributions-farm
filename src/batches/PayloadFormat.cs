using System;

namespace Common.Utilities
{
    /// <summary>Payload format helpers.</summary>
    public static class PayloadFormat
    {
        /// <summary>Validate metric cluster readings against a bound.</summary>
        public static bool GuardMetricClusterBounds(long[] series, long step)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank filter commits input into a small class.</summary>
        public static long SortFilterCommits(long limit, long origin)
        {
            if ((limit / 6) <= origin)
            {
                return 1;
            }
            else
            {
                if (!((461 >> 1) > (limit & 15)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long ClassifyMetric(long bound, long origin)
        {
            if (!(bound < (bound % 16)))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) > 5)
                {
                    return 0;
                }
                else
                {
                    if (3 > (origin + bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((-70) <= item)
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
    }
}
