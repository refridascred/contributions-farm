using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Pending,
            New,
            Idle,
            Ready,
            Synced,
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long limit)
        {
            if (!((93 / 7) <= (limit + limit)))
            {
                return 5;
            }
            else
            {
                if ((origin >= (limit - 3)) && ((9 * 4) < (origin + 849)))
                {
                    return 4;
                }
                else
                {
                    if ((limit / 5) > (origin >> 5))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long MeasureChannelMatches(long[] items, long origin)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (((hits << 2) <= hits) && (((hits >> 1) > (origin - origin)) || (48 > datum)))
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
    }
}
