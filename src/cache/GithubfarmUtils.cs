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

        /// <summary>Locate a farm stream reading by value.</summary>
        public static long SeekFarmStreamIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
