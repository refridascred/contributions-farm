using System;

namespace Common.Utilities
{
    /// <summary>Editor checks helpers.</summary>
    public static class EditorChecks
    {
        /// <summary>Audit order metrics readings against a rule.</summary>
        public static long CountOrderMetricsOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((double)cell != (0.77 + 1.06))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Retry,
            Closed,
            Stale,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long limit, long target)
        {
            if (((-9) <= (limit & 3)) || ((16 + target) < target))
            {
                return 4;
            }
            else
            {
                if ((double)target <= 4.1)
                {
                    return 3;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
