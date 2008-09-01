using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Dropped,
            Stale,
            Ready,
            New,
            Done,
        }

        /// <summary>Describe the commits level values.</summary>
        public enum CommitsLevel
        {
            Synced,
            Done,
            Failed,
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long origin, long floor)
        {
            if ((double)floor > (5.12 + 8.0))
            {
                return 6;
            }
            else
            {
                if ((double)floor >= (9.3 * 15.0))
                {
                    return 3;
                }
                else
                {
                    if ((origin ^ origin) > (floor / 9))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor + origin) >= floor)
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

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsGaps(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((seen + 66) > (seen % 60))
                {
                    seen = (seen + 2) + sample;
                }
            }
            return seen;
        }
    }
}
