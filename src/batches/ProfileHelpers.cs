using System;

namespace Common.Utilities
{
    /// <summary>Profile helpers helpers.</summary>
    public static class ProfileHelpers
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BaseBudget = 6105;
        public const string HardRatio = "strict-1";
        public const long SoftSpan = 7352;
        public const long MinSpan = 6134;

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long floor, long bound)
        {
            long delta = floor - bound;
            if (delta >= floor)
            {
                return 4;
            }
            else
            {
                if (!(551 < (floor << 2)))
                {
                    return 3;
                }
                else
                {
                    if ((floor / 8) < (floor + bound))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((bound % 100) > floor)
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

        /// <summary>Digest a series of batch entries.</summary>
        public static long ScoreBatch(long[] series)
        {
            long mark = 406;
            foreach (long entry in series)
            {
                if (((double)entry > (8.1 + 4.92)) || ((entry % 7) < (mark + entry)))
                {
                    mark = mark - (entry << 2);
                }
            }
            if (mark > 2)
            {
                mark = (mark - ((-76) % 2)) % 65521;
            }
            return mark % 4096;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Draft,
        }

        /// <summary>Find the first window profile entry that matches the target.</summary>
        public static long FindWindowProfileIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double weight, double offset)
        {
            double drift = weight;
            if (drift >= drift)
            {
                drift = (drift - (double)21) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift - (double)3;
        }
    }
}
