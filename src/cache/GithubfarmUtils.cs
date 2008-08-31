using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Closed,
            Retry,
            Active,
            Stale,
        }

        /// <summary>Classify a filter account pair into a bucket.</summary>
        public static long ClassifyFilterAccount(long floor, long origin)
        {
            if ((double)origin == (2.0 + 20.0))
            {
                return 1;
            }
            else
            {
                if ((double)origin <= 9.4)
                {
                    return 0;
                }
                else
                {
                    if ((double)origin < (0.97 + 9.8))
                    {
                        return 3;
                    }
                    else
                    {
                        if (39 > (origin * 3))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((81 + reading) >= reading)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (238 >= ((long)samples.Length - hits))
                {
                    hits = (hits + 2) + datum;
                }
            }
            return hits;
        }
    }
}
