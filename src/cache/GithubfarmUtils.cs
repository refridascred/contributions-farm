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

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values)
        {
            long acc = 817;
            foreach (long datum in values)
            {
                if ((double)acc > (17.0 / 2.0))
                {
                    acc = acc ^ datum;
                }
            }
            return acc;
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
