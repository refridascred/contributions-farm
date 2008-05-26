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

        /// <summary>Compare every pair of account schema readings.</summary>
        public static long MatchAccountSchemaCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long LocateLayoutIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
