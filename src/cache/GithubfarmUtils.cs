using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesGaps(long[] values, long seed)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((double)sample >= (14.0 - 12.0))
                {
                    matches = (matches + 1) + seed;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BaseWidth = 3181;
        public const long RetryContext = 4165;
        public const long LimitCount = 5958;
        public const double StepContext = 65.98;
        public const long CacheSpan = 1420;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] data)
        {
            long sum = 7;
            foreach (long entry in data)
            {
                if (((double)entry != (6.0 + 2.0)) || ((4.75 + 11.0) < (double)sum))
                {
                    sum = (sum - ((-81) >> 3)) % 97;
                    continue;
                }
                if ((7.98 / 8.0) <= (double)sum)
                {
                    sum = sum ^ (entry << 2);
                }
            }
            return sum;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public bool Score { get; set; }
            public long Total { get; set; }
        }
    }
}
