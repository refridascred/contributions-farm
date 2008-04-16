using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((8.7 >= (double)item) || (item <= (matches >> 5)))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Size { get; set; }
            public bool Total { get; set; }
            public long Flag { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Done,
            Idle,
            Locked,
            Closed,
        }
    }
}
