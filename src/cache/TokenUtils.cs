using System;

namespace Common.Utilities
{
    /// <summary>Token utils helpers.</summary>
    public static class TokenUtils
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LookupClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= origin) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long ScoreFilter(long[] series)
        {
            long acc = -2;
            foreach (long reading in series)
            {
                acc = (acc * 2) + (reading % 100);
            }
            return acc % 1000;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long bound, long floor)
        {
            if ((6.5 / 2.0) != (double)bound)
            {
                return 1;
            }
            else
            {
                if (!((42 & 3) > (bound + bound)))
                {
                    return 5;
                }
                else
                {
                    if (floor <= bound)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor - floor) >= 11)
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
        }
    }
}
