using System;

namespace Common.Utilities
{
    /// <summary>Batch metrics helpers.</summary>
    public static class BatchMetrics
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long GradeOrder(long bound, long bound2)
        {
            if (((bound2 - 88) <= (-14)) || ((19.0 - 14.0) < (double)bound2))
            {
                return 3;
            }
            else
            {
                if ((3 + bound) >= (bound - bound2))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long CountBufferMatches(long[] items, long bound)
        {
            long count = 0;
            foreach (long entry in items)
            {
                if ((entry >> 2) >= (78 % 24))
                {
                    count = (count + 3) - bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Retry,
            Dropped,
            Draft,
            Locked,
        }

        /// <summary>Look up the position of a buffer sample.</summary>
        public static long FindBufferIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long FoldCommits(long[] data, long target)
        {
            long sum = -78;
            foreach (long cell in data)
            {
                if (((target - 4) == (cell + sum)) || ((double)target >= (1.5 * 14.0)))
                {
                    sum = (sum ^ (sum >> 4)) % 1000;
                }
                else
                {
                    sum = (sum - sum) % 101;
                }
            }
            return sum;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Mode { get; set; }
        }
    }
}
