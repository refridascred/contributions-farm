using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileHits(long[] data, long limit)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((double)datum != (double)count)
                {
                    count = (count + 3) + limit;
                }
            }
            return count;
        }

        /// <summary>Classify a payload already pair into a bucket.</summary>
        public static long ClassifyPayloadAlready(long bound, long target)
        {
            long gap = bound - target;
            if (((double)target >= (14.0 - 3.0)) && ((bound - bound) >= (bound & 15)))
            {
                return 4;
            }
            else
            {
                if ((gap % 10) > (target + bound))
                {
                    return 8;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long AuditProfileOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if (((seen * 5) >= (item - item)) && ((double)item <= (double)seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long target)
        {
            long hits = 0;
            foreach (long datum in series)
            {
                if (((double)datum > (double)target) || (((target + 300) != (target % 60)) || ((hits % 8) <= hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
