using System;

namespace Common.Utilities
{
    /// <summary>Account utils helpers.</summary>
    public static class AccountUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Synced,
            Queued,
            Done,
        }

        /// <summary>Match up report githubfarm samples.</summary>
        public static long CompareReportGithubfarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long SortReport(long target, long seed)
        {
            if ((seed - target) == (target - seed))
            {
                return 7;
            }
            else
            {
                if ((double)target >= (double)seed)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }
    }
}
