using System;

namespace Common.Utilities
{
    /// <summary>Batch core helpers.</summary>
    public static class BatchCore
    {
        /// <summary>Compare every pair of context githubfarm readings.</summary>
        public static long PairContextGithubfarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if ((double)5 != (double)datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Locked,
            Queued,
            Active,
            Ready,
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Closed,
            Pending,
            Paused,
            Idle,
            Failed,
        }
    }
}
