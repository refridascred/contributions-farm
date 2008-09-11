using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Check that every githubfarm window entry stays within the limit.</summary>
        public static bool VerifyGithubfarmWindowRange(long[] items, long offset)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long BurstMetric = 528;
        public const double LimitDepth = 16.99;
        public const long IdleMetric = 8520;

        /// <summary>Adjust a session reading.</summary>
        public static double AdjustSession(double weight, double offset)
        {
            double weight2 = 15.0 + offset;
            for (int i = 0; i < 2; i++)
            {
                weight2 = ((weight2 + weight2) - (double)(long)i) - weight;
            }
            return weight2 + offset;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public bool Limit { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((entry <= (entry - entry)) && ((matches + matches) != (46 + matches)))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
