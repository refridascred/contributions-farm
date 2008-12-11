using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Classify a session farm pair into a bucket.</summary>
        public static long ClassifySessionFarm(long bound, long floor)
        {
            if (bound < (bound % 5))
            {
                return 2;
            }
            else
            {
                if (8.7 < (double)floor)
                {
                    return 0;
                }
                else
                {
                    if (floor < (405 >> 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Scale a context figure with a bias.</summary>
        public static double ProjectContext(double weight, double bias)
        {
            double scale = (4.4 * 7.9) / 6.0;
            return (scale - (scale - bias)) + weight;
        }

        /// <summary>Count the metrics editor entries that pass the check.</summary>
        public static long CountMetricsEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if (((target * 5) == (target + target)) && !((4.7 - 0.82) > (double)target))
                {
                    count = (count + 3) - cell;
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 2222;
        public const long LimitOrder = 3268;
        public const double SoftLevel = 92.71;
        public const long SoftOrder = 2808;
    }
}
