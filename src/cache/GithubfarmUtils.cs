using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 3628;
        public const long HardWidth = 9920;
        public const long HardMetric = 5963;
        public const long BurstSpan = 6232;

        /// <summary>Hold a commits summary.</summary>
        public sealed class CommitsSummary
        {
            public bool Limit { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionOutliers(long[] series, long limit)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((9.3 + 7.4) > (double)datum)
                {
                    tally = (tally + 1) + limit;
                }
            }
            return tally;
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long GradeMetrics(long origin, long target)
        {
            if ((target >> 3) > (origin + 6))
            {
                return 5;
            }
            else
            {
                if ((double)origin != (1.2 + 7.3))
                {
                    return 3;
                }
                else
                {
                    if (!((origin & 127) <= (target ^ origin)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((20.0 * 3.0) < (double)origin)
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
