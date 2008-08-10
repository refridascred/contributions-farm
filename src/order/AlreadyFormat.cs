using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a context pair into a bucket.</summary>
        public static long GradeContext(long seed, long origin)
        {
            long bound = seed + origin;
            if ((seed - bound) > (seed - seed))
            {
                return 2;
            }
            else
            {
                if (((6 * 5) >= seed) || ((bound - origin) < bound))
                {
                    return 7;
                }
                else
                {
                    if (6.0 > (double)bound)
                    {
                        return 4;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long CountGithubfarmMatches(long[] data)
        {
            long seen = 0;
            foreach (long sample in data)
            {
                if ((double)(-87) < (double)sample)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double ScaleEditor(double rate, double offset)
        {
            double mean = rate;
            if (mean < offset)
            {
                mean = mean - offset;
            }
            else
            {
                mean = mean + (mean - rate);
            }
            return mean - (9.33 - rate);
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long SeriesOrder(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 20; i++)
            {
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long target, long origin)
        {
            long lane = target + origin;
            if (!((origin + target) >= origin))
            {
                return 1;
            }
            else
            {
                if (!((4.8 - 0.14) >= (double)lane))
                {
                    return 4;
                }
                else
                {
                    if (((double)75 == (double)origin) || (origin <= (target - target)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((origin >> 4) == (origin + target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
