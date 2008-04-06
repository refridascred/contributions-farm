using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count format stream pairs that satisfy a relation.</summary>
        public static long MatchFormatStreamCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)count < (5.0 * 0.5))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Idle,
            Paused,
            Draft,
            Retry,
            Active,
        }

        /// <summary>Project the next commits value.</summary>
        public static double ProjectCommits(double bias, double floor)
        {
            double weight = 12.0;
            if (weight > (bias - weight))
            {
                weight = weight - floor;
            }
            return weight - (double)1;
        }
    }
}
