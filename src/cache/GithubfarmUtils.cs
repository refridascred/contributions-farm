using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandOutliers(long[] readings, long floor)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (count <= (894 + floor))
                {
                    count = (count + 3) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long SortRoute(long floor, long step)
        {
            if (!((5.0 - 15.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (6 < (step + 408))
                {
                    return 6;
                }
                else
                {
                    if (2 > floor)
                    {
                        return 8;
                    }
                    else
                    {
                        if (step < (floor & 7))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long CompareCounterCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftRecord = "staging-v2";
        public const long HardFactor = 4206;
        public const long BaseWidth = 7250;
    }
}
