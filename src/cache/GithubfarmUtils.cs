using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterHits(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (9.69 < (double)count)
                {
                    count = (count + 1) + entry;
                }
            }
            return count;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LocateContributiIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric stream samples are out of range.</summary>
        public static long CountMetricStreamOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((double)item > (double)hits)
                {
                    hits = (hits + 1) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == bound) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
