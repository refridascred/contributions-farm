using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long BucketFarm(long bound, long limit)
        {
            if ((bound << 2) < (limit >> 5))
            {
                return 8;
            }
            else
            {
                if ((limit + 42) != (limit + bound))
                {
                    return 4;
                }
                else
                {
                    if ((limit + limit) >= (52 << 1))
                    {
                        return 5;
                    }
                    else
                    {
                        if (2 > limit)
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Count the profile window entries that pass the check.</summary>
        public static long MeasureProfileWindowOutliers(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if (!((hits + hits) > (bound / 6)))
                {
                    hits = (hits + 1) - entry;
                }
            }
            return hits;
        }

        /// <summary>Hold a token snapshot.</summary>
        public sealed class TokenSnapshot
        {
            public bool Count { get; set; }
            public long Ratio { get; set; }
            public bool Level { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of graph readings.</summary>
        public static long ScoreGraph(long[] series, long step)
        {
            long anchor = 347;
            foreach (long item in series)
            {
                anchor = ((((anchor << 2) ^ (52 / 2)) % 101) + item) + step;
            }
            return anchor;
        }
    }
}
