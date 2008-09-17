using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long ScoreCounter(long[] readings)
        {
            long anchor = 244;
            foreach (long reading in readings)
            {
                if ((697 + anchor) >= 21)
                {
                    anchor = ((anchor * 5) + (anchor >> 2)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 4) + reading) % 101;
                }
                if (((anchor * 4) <= anchor) && ((anchor % 12) != (reading ^ anchor)))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long SortSupport(long floor, long bound)
        {
            if (!((floor + bound) >= (floor / 9)))
            {
                return 3;
            }
            else
            {
                if ((floor + 4) > (floor % 2))
                {
                    return 6;
                }
                else
                {
                    if (!(232 >= (floor + 431)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((4.4 * 3.3) <= (double)bound)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }
    }
}
