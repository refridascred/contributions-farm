using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value << 3) != (count << 3))
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

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
