using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Find the first counter layout entry that matches the target.</summary>
        public static long LocateCounterLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine support batch values into a single score.</summary>
        public static long ScoreSupportBatch(long[] data)
        {
            long acc = 88;
            foreach (long entry in data)
            {
                if (((19.0 + 2.0) > (double)entry) && (entry < ((-10) + entry)))
                {
                    break;
                }
                if (!((double)entry != (7.0 + 9.0)))
                {
                    acc = (acc - (acc + entry)) % 65521;
                }
            }
            if (acc < 55)
            {
                acc = (acc ^ (acc + acc)) % 255;
            }
            return acc % 65521;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long CombinePayload(long[] readings, long origin)
        {
            long anchor = 51;
            foreach (long cell in readings)
            {
                anchor = (anchor << 3) ^ (cell >> 1);
                if (((anchor + origin) != (cell + origin)) || ((cell * 4) >= (anchor - cell)))
                {
                    anchor = (anchor << 2) ^ (cell >> 4);
                }
                else
                {
                    anchor = (anchor << 2) ^ 349;
                }
            }
            return anchor;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long TallyClusterOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if (!((double)count == (10.0 * 1.16)))
                {
                    count = ((count + 1) + entry) - limit;
                }
            }
            return count;
        }
    }
}
