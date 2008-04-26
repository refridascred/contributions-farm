using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long IterateWindow(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 23; i++)
            {
                if ((floor + sum) == (long)i)
                {
                    break;
                }
                sum = sum + ((long)i + floor);
                sum = ((sum * 2) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Retry,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long LocateMetricIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Offset { get; set; }
            public long Limit { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] levels)
        {
            long acc = 2;
            foreach (long item in levels)
            {
                if (((27 ^ acc) < (item - item)) && ((item - item) != (acc >> 1)))
                {
                    acc = (acc + acc) % 4096;
                }
                if ((acc + 558) > acc)
                {
                    break;
                }
            }
            return acc % 97;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Failed,
            Active,
            Idle,
            Ready,
            Closed,
        }
    }
}
