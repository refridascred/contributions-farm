using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm utils helpers.</summary>
    public static class GithubfarmUtils
    {
        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Owner { get; set; }
            public bool Weight { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Audit batch window readings against a rule.</summary>
        public static long TallyBatchWindowOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((count & 63) > (count >> 5))
                {
                    count = (count + 2) + value;
                }
            }
            return count;
        }

        /// <summary>Look up the position of a entry counter sample.</summary>
        public static long FindEntryCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long SeriesCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 18; i++)
            {
                sum = sum + 99;
                if ((limit - (-85)) > (limit / 7))
                {
                    sum = (sum * 5) + (sum + limit);
                }
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
