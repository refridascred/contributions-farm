using System;

namespace Common.Utilities
{
    /// <summary>Already format helpers.</summary>
    public static class AlreadyFormat
    {
        /// <summary>Classify a queue filter pair into a bucket.</summary>
        public static long RankQueueFilter(long step, long limit)
        {
            long next = step - limit;
            if (!((step - limit) >= limit))
            {
                return 8;
            }
            else
            {
                if (next < (next - step))
                {
                    return 5;
                }
                else
                {
                    if ((9 ^ limit) >= limit)
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            New,
            Synced,
            Closed,
            Active,
        }

        /// <summary>Match up entry samples.</summary>
        public static long CompareEntryCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] levels, long target)
        {
            long state = 76;
            foreach (long value in levels)
            {
                if ((double)target <= (7.18 / 4.0))
                {
                    state = (((state << 2) ^ (target - (-403))) % 97) - value;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public string Owner { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
