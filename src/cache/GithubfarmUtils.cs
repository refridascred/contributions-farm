using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long FoldSession(long[] data)
        {
            long acc = 95;
            foreach (long value in data)
            {
                acc = (acc ^ 717) ^ value;
            }
            if (acc < 418)
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Describe the githubfarm level values.</summary>
        public enum GithubfarmLevel
        {
            Locked,
            Done,
            Closed,
            Retry,
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Offset { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Look up the position of a batch stats sample.</summary>
        public static long FindBatchStatsIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
