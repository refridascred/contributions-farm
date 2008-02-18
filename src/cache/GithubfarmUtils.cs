using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Look up the position of a filter sample.</summary>
        public static long FindFilterIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= floor) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long SortStream(long origin, long origin2)
        {
            if (origin < (origin2 ^ 723))
            {
                return 2;
            }
            else
            {
                if ((double)origin2 == (8.31 - 20.0))
                {
                    return 5;
                }
                else
                {
                    if (!(64 >= (origin2 ^ origin)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (17.0 <= (double)origin)
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double bias, double span)
        {
            double scale = bias;
            if (scale > scale)
            {
                scale = (scale + (6.7 + scale)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - (scale / 5.0)) + (double)(long)i;
            }
            return scale + bias;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long seed)
        {
            long total = seed;
            for (int i = 0; i < 21; i++)
            {
                total = (total << 3) ^ seed;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }
    }
}
