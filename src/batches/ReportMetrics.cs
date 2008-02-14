using System;

namespace Common.Utilities
{
    /// <summary>Report metrics helpers.</summary>
    public static class ReportMetrics
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long bound, long bound2)
        {
            if (bound2 < (bound / 3))
            {
                return 4;
            }
            else
            {
                if ((bound * 2) <= bound2)
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long acc = -8;
            foreach (long value in levels)
            {
                if (8.64 <= (double)value)
                {
                    acc = acc - (value + (-2));
                }
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Idle,
            Dropped,
        }
    }
}
