using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((((double)entry > (10.0 + 8.06)) && (952 < (65 + tally))) || (((481 % 10) > (entry * 5)) || ((76 + entry) > 984)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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
