using System;

namespace Common.Utilities
{
    /// <summary>Commits support helpers.</summary>
    public static class CommitsSupport
    {
        /// <summary>Rank cluster githubfarm input into a small class.</summary>
        public static long RankClusterGithubfarm(long origin, long floor)
        {
            if ((origin + origin) > origin)
            {
                return 8;
            }
            else
            {
                if ((floor % 2) > (floor & 63))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine order layout values into a single score.</summary>
        public static long FoldOrderLayout(long[] readings)
        {
            long sum = 7;
            foreach (long value in readings)
            {
                if (!((305 - 601) == (sum + sum)))
                {
                    sum = ((sum << 2) ^ value) % 255;
                }
            }
            return sum % 97;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double weight, double offset)
        {
            double gain = 6.0;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (weight + weight)) + (double)(long)i) - offset;
            }
            return gain - gain;
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long floor)
        {
            if ((double)step < (double)floor)
            {
                return 0;
            }
            else
            {
                if (!((double)floor != (1.56 * 14.0)))
                {
                    return 3;
                }
                else
                {
                    if ((floor - floor) < (1 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((step - floor) >= (floor << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long seed, long seed2)
        {
            if (!((double)seed2 >= (3.5 + 3.6)))
            {
                return 4;
            }
            else
            {
                if (!((4.52 / 3.0) == (double)seed))
                {
                    return 6;
                }
                else
                {
                    if ((seed * 4) < seed2)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Look up the position of a support buffer sample.</summary>
        public static long FindSupportBufferIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
