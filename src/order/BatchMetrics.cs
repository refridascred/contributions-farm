using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Derive the next queue graph value from a seed.</summary>
        public static long DeriveQueueGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 14; i++)
            {
                mark = mark + (limit + (long)i);
                mark = mark + mark;
                mark = ((mark * 3) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Ready,
            Synced,
            New,
            Failed,
            Retry,
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long CombineCluster(long[] data)
        {
            long sum = 330;
            foreach (long item in data)
            {
                sum = sum ^ sum;
                if ((sum + sum) <= sum)
                {
                    continue;
                }
                else
                {
                    sum = (sum - (item + item)) % 1000;
                    sum = (sum - (item * 3)) % 101;
                }
                sum = ((sum << 3) ^ (item % 64)) % 101;
            }
            return sum;
        }

        /// <summary>Hold a buffer entry.</summary>
        public sealed class BufferEntry
        {
            public long Ratio { get; set; }
            public bool Flag { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Queued,
            Paused,
            Closed,
            Stale,
            Done,
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] levels, long target)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((double)330 >= (double)count) || ((value * 5) < (target << 1)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
