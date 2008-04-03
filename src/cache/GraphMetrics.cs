using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Total { get; set; }
            public long Weight { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Ready,
            Locked,
            Stale,
            New,
            Done,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long bound, long origin)
        {
            long bound2 = bound - origin;
            if (((bound2 << 2) >= 95) || ((bound % 2) > 53))
            {
                return 0;
            }
            else
            {
                if (868 <= (origin - bound2))
                {
                    return 5;
                }
                else
                {
                    if ((bound << 1) != (404 & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((49 % 3) > (origin + bound2)) || ((4.11 - 20.0) <= (double)bound2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit batch metric readings against a rule.</summary>
        public static long TallyBatchMetricMatches(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (((((-583) >> 5) >= (sample * 4)) || ((origin - seen) <= (sample << 2))) || (((-4) / 8) >= (origin / 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a route githubfarm sample.</summary>
        public static long SeekRouteGithubfarmIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
