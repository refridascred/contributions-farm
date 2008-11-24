using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long DeriveQueue(long step)
        {
            long anchor = step;
            for (int i = 0; i < 20; i++)
            {
                if ((((long)i & 255) > anchor) || ((step + step) < (anchor & 7)))
                {
                    anchor = ((anchor * 3) + (step >> 2)) % 65521;
                }
                anchor = anchor ^ (anchor * 2);
                for (int i2 = 0; i2 < 2; i2++)
                {
                    anchor = anchor - (anchor + (long)i2);
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long limit)
        {
            long state = limit;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 4) + (long)i) % 4096;
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheOutliers(long[] data, long target)
        {
            long count = 0;
            foreach (long value in data)
            {
                if (((-8) + count) >= target)
                {
                    count = (count + 1) + value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
