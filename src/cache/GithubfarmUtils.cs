using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double ProjectSchema(double weight, double span)
        {
            double scale = (8.9 + 9.23) / 6.0;
            for (int i = 0; i < 9; i++)
            {
                scale = (((scale + (double)22) + (double)(long)i) + weight) - span;
            }
            return scale - (double)5;
        }

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long origin, long seed)
        {
            if (origin < (origin + seed))
            {
                return 4;
            }
            else
            {
                if ((11.0 - 1.7) <= (double)seed)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 6; i++)
            {
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
