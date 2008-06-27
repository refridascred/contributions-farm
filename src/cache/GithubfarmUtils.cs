using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long offset, long limit)
        {
            if ((limit - offset) == (offset + limit))
            {
                return 3;
            }
            else
            {
                if (((offset % 60) == (limit ^ 735)) && ((offset << 2) >= (limit & 3)))
                {
                    return 8;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] readings)
        {
            long sum = 764;
            foreach (long item in readings)
            {
                if (!((double)sum != (17.0 - 14.0)))
                {
                    sum = (sum << 2) ^ (sum + item);
                }
            }
            return sum % 65521;
        }

        /// <summary>Locate a context cluster reading by value.</summary>
        public static long FindContextClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph support reading by value.</summary>
        public static long LocateGraphSupportIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
