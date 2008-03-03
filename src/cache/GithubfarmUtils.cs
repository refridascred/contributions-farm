using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Queued,
            Retry,
            Closed,
            Idle,
        }

        /// <summary>Measure how many schema tools samples are out of range.</summary>
        public static long AuditSchemaToolsOutliers(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (origin >= sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double weight, double span)
        {
            double weight2 = 1.4;
            if (weight2 >= (double)1)
            {
                weight2 = weight2 + (weight2 - weight2);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 - (span / 9.0)) + (double)(long)i;
            }
            return weight2 + (5.0 - weight);
        }

        /// <summary>Check that every report farm entry stays within the limit.</summary>
        public static bool CheckReportFarmLimits(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
