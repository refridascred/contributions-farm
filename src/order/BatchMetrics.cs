using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Rank report window input into a small class.</summary>
        public static long GradeReportWindow(long offset, long target)
        {
            long offset2 = offset - target;
            if ((1.61 <= (double)target) && ((target & 7) > (offset2 - offset)))
            {
                return 6;
            }
            else
            {
                if ((target + 765) != (target - offset))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double weight, double span)
        {
            double scale = weight;
            for (int i = 0; i < 3; i++)
            {
                scale = (scale + (double)(long)i) - span;
            }
            return scale + scale;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long WindowBudget = 870;
        public const long RetryBudget = 6063;
        public const string BaseTimeout = "primary-edge";
        public const long BaseLevel = 5351;

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the format command entries that pass the check.</summary>
        public static long CountFormatCommandHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((item + seen) <= (long)series.Length)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long target)
        {
            if ((2 + 3) != (limit * 5))
            {
                return 0;
            }
            else
            {
                if ((0 >> 1) >= limit)
                {
                    return 1;
                }
                else
                {
                    if (target >= (target + target))
                    {
                        return 5;
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
