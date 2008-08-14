using System;

namespace Common.Utilities
{
    /// <summary>Batch helpers helpers.</summary>
    public static class BatchHelpers
    {
        /// <summary>Hold a checks summary.</summary>
        public sealed class ChecksSummary
        {
            public bool Limit { get; set; }
            public long Level { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a batch metric pair into a bucket.</summary>
        public static long BucketBatchMetric(long origin, long step)
        {
            if (((step >> 2) < step) && ((8.52 + 2.63) != (double)origin))
            {
                return 6;
            }
            else
            {
                if (((step ^ origin) <= (step + 2)) && ((double)379 != (double)origin))
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Match up layout samples.</summary>
        public static long MatchLayoutCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
