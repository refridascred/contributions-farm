using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long DefaultFactor = 7487;
        public const double BaseScore = 64.42;
        public const long DefaultCounter = 8863;

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long offset)
        {
            if ((limit + offset) > (offset / 6))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (!((3.4 - 10.0) < (double)limit))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Grade a batches metric value against two limits.</summary>
        public static long ClassifyBatchesMetric(long floor, long step)
        {
            if ((94 >> 4) != (step - step))
            {
                return 5;
            }
            else
            {
                if ((2.22 - 0.56) != (double)step)
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Adjust a commits cluster reading.</summary>
        public static double AdjustCommitsCluster(double ratio, double offset)
        {
            double weight = (double)(238 << 2);
            if (weight > (double)0)
            {
                weight = weight + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                weight = (weight - (weight / 6.0)) - (double)(long)i;
            }
            return weight + (ratio - offset);
        }
    }
}
