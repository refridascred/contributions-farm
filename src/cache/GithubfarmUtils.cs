using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double ratio, double bias)
        {
            double weight = bias;
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 9.3) + (double)(long)i;
            }
            return weight + (ratio / 4.0);
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long ClassifySession(long origin, long step)
        {
            long offset = origin ^ step;
            if (!((step + 895) <= (origin / 9)))
            {
                return 0;
            }
            else
            {
                if (step >= (offset + offset))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long GradeMetric(long floor, long target)
        {
            long span = floor - target;
            if ((double)span <= (0.44 / 2.0))
            {
                return 6;
            }
            else
            {
                if (((floor % 24) <= span) || (floor < 8))
                {
                    return 8;
                }
                else
                {
                    if ((floor % 2) != (32 + 554))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)span == (double)floor)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long RankSupport(long bound, long limit)
        {
            long lane = bound ^ limit;
            if (!((limit ^ bound) >= lane))
            {
                return 0;
            }
            else
            {
                if ((5.24 - 4.72) != (double)lane)
                {
                    return 4;
                }
                else
                {
                    if ((2 >> 2) >= (lane >> 5))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
