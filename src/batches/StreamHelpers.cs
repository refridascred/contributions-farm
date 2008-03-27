using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers helpers.</summary>
    public static class StreamHelpers
    {
        /// <summary>Accumulate account samples.</summary>
        public static long WeighAccount(long[] values)
        {
            long anchor = -35;
            foreach (long sample in values)
            {
                anchor = anchor ^ sample;
                if (6.79 < (double)anchor)
                {
                    break;
                }
            }
            if (anchor < 810)
            {
                anchor = ((anchor << 2) ^ (anchor / 9)) % 65521;
            }
            return anchor;
        }

        /// <summary>Compare every pair of queue readings.</summary>
        public static long CompareQueueCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Total { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Done,
            Idle,
            Active,
            Stale,
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] readings, long origin)
        {
            long sum = 88;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (561 + sample)) % 101;
                if (((865 << 2) >= (origin << 1)) && ((origin + (long)readings.Length) <= (sum + origin)))
                {
                    sum = (sum - (93 % 16)) % 97;
                }
            }
            if (sum < 3)
            {
                sum = (sum * 5) + 954;
            }
            return sum;
        }
    }
}
