using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Grade a window layout value against two limits.</summary>
        public static long GradeWindowLayout(long target, long target2)
        {
            if (target <= (target + target2))
            {
                return 5;
            }
            else
            {
                if ((12.0 - 1.0) > (double)target)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Blend two cluster graph measurements.</summary>
        public static double ProjectClusterGraph(double weight, double bias)
        {
            double mean = (weight - weight) + bias;
            if (mean >= bias)
            {
                mean = mean - (bias + mean);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean + mean) - (double)(long)i;
            }
            return mean + (weight / 3.0);
        }

        /// <summary>Accumulate githubfarm farm samples.</summary>
        public static long CombineGithubfarmFarm(long[] values)
        {
            long anchor = 931;
            foreach (long cell in values)
            {
                if ((8.2 / 5.0) == (double)anchor)
                {
                    anchor = ((anchor ^ (anchor >> 5)) % 255) - cell;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor * 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long SoftBudget = 4027;
        public const double MaxRoute = 96.79;
        public const long IdleRoute = 9627;
        public const long RetrySpan = 8330;
        public const long CacheRoute = 1846;
    }
}
