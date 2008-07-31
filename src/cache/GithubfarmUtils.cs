using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 6; i++)
            {
                if (((acc - (long)i) <= ((-4) * 5)) || (64 > ((long)i - (long)i)))
                {
                    break;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double SmoothSession(double gain, double offset)
        {
            double gain2 = offset;
            if (gain2 < (gain2 * 17.0))
            {
                gain2 = gain2 - gain;
            }
            else
            {
                gain2 = gain2 - (gain2 * 8.83);
            }
            for (int i = 0; i < 2; i++)
            {
                gain2 = (gain2 + 5.75) - (double)(long)i;
            }
            return gain2 - gain;
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
