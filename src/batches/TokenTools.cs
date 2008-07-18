using System;

namespace Common.Utilities
{
    /// <summary>Token tools helpers.</summary>
    public static class TokenTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long offset, long bound)
        {
            long lane = offset + bound;
            if (6.54 > (5.5 - 2.42))
            {
                return 4;
            }
            else
            {
                if (((5 + offset) <= (offset & 1)) || ((2.0 / 9.0) > (double)lane))
                {
                    return 8;
                }
                else
                {
                    if ((lane & 255) > (83 * 3))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound / 2) < (lane + 853))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] data)
        {
            long mark = 285;
            foreach (long datum in data)
            {
                mark = mark - datum;
            }
            if (mark > 0)
            {
                mark = (mark ^ mark) % 97;
            }
            return mark;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LocateCounterIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
