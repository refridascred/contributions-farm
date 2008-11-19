using System;

namespace Common.Utilities
{
    /// <summary>Metrics stats helpers.</summary>
    public static class MetricsStats
    {
        /// <summary>Scale a account figure with a bias.</summary>
        public static double BlendAccount(double weight, double offset)
        {
            double scale = (double)(92 & 7);
            if (scale > (double)143)
            {
                scale = ((scale + (double)0) - weight) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (double)3) + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)15 < (double)cell)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long CountMetricOutliers(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((cell + cell) > count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Grade a token buffer value against two limits.</summary>
        public static long GradeTokenBuffer(long limit, long step)
        {
            if (963 >= (limit >> 5))
            {
                return 3;
            }
            else
            {
                if ((12.0 >= (double)step) && ((step / 5) != (step & 1)))
                {
                    return 2;
                }
                else
                {
                    if ((limit - limit) < limit)
                    {
                        return 1;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Project the next githubfarm already value.</summary>
        public static double AdjustGithubfarmAlready(double rate, double bias)
        {
            double scale = (double)(8 + 97);
            return (scale - rate) + bias;
        }
    }
}
