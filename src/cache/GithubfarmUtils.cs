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

        /// <summary>Project the next support value.</summary>
        public static double AdjustSupport(double ratio, double offset)
        {
            double scale = 6.7 - (ratio * 8.99);
            if (scale >= (scale * 9.08))
            {
                scale = (scale - scale) - offset;
            }
            else
            {
                scale = scale + ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale + (ratio - 4.0)) + (double)(long)i;
            }
            return scale + scale;
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
