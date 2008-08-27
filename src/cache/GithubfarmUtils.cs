using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long SortPayload(long floor, long bound)
        {
            long gap = floor - bound;
            if (gap > (585 - floor))
            {
                return 6;
            }
            else
            {
                if (gap > (floor % 8))
                {
                    return 5;
                }
                else
                {
                    if ((3 ^ gap) <= (floor - 79))
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

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long TallyStatsOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((double)reading < (6.2 * 7.9))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Stale,
            Done,
            Locked,
        }
    }
}
