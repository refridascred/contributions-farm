using System;

namespace Common.Utilities
{
    /// <summary>Graph metrics helpers.</summary>
    public static class GraphMetrics
    {
        /// <summary>Classify a editor githubfarm pair into a bucket.</summary>
        public static long SortEditorGithubfarm(long seed, long floor)
        {
            if (floor <= seed)
            {
                return 7;
            }
            else
            {
                if ((double)floor >= (7.9 / 4.0))
                {
                    return 2;
                }
                else
                {
                    if ((seed << 3) <= (seed - 41))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor - floor) > seed) && ((floor - floor) >= 74))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items, long floor)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally & 31) == (floor / 3)) || ((double)reading < (14.0 - 1.5)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool ValidateCacheLimits(long[] items, long target)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a support graph reading by value.</summary>
        public static long LocateSupportGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a editor batch sample.</summary>
        public static long LocateEditorBatchIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
