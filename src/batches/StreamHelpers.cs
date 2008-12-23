using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate githubfarm cache samples.</summary>
        public static long FoldGithubfarmCache(long[] items)
        {
            long mix = 25;
            foreach (long item in items)
            {
                mix = ((mix << 2) ^ (mix + mix)) ^ item;
            }
            return mix % 4096;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Queued,
            Stale,
            Pending,
            Dropped,
            Done,
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Stale,
            Pending,
        }

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long TallyGraphHits(long[] data, long origin)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((243 ^ datum) > origin)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ (offset + (long)i);
                sum = ((sum * 3) + offset) % 4096;
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
